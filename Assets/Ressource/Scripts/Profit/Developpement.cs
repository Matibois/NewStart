using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Entreprise;

public class Developpement : MonoBehaviour
{
    public Slider ProfitSlider;

    public GameObject marche;
    public GameObject profil;
    private Entreprise entreprise;

    [SerializeField] public Worket worket;
    [SerializeField] public Marche WhiteMontain;
    [SerializeField] public Marche PalmCoconut;
    [SerializeField] public Marche FenzyFarm;
    [SerializeField] public Marche UrbanCity;
    private Marche Place;
    private Marche Concurrent;

    private place lieu;
    private shop job;

    private int CJeunes = 0;
    private int CAdultes = 0;
    private int CVieux = 0;

    private int CPauvres = 0;
    private int CMoyens = 0;
    private int CRiches = 0;

    private int Profit;

    private void Start()
    {
        worket = FindObjectOfType<Worket>();
        worket = worket.initiateWorket(worket);
        entreprise = FindObjectOfType<Entreprise>();

        WhiteMontain = worket.WhiteMontain;
        UrbanCity = worket.UrbanCity;
        FenzyFarm = worket.FenzyFarm;
        PalmCoconut = worket.PalmCoconut;

        lieu = entreprise.GetPlace();
        job = entreprise.GetShop();

        DefinePlace();
    }

    public void GetData()
    {
        worket = FindObjectOfType<Worket>();
        worket = worket.initiateWorket(worket);
        entreprise = FindObjectOfType<Entreprise>();

        WhiteMontain = worket.WhiteMontain;
        UrbanCity = worket.UrbanCity;
        FenzyFarm = worket.FenzyFarm;
        PalmCoconut = worket.PalmCoconut;

        lieu = entreprise.GetPlace();
        job = entreprise.GetShop();

    }
    public void EvaluateProfit()
    {
        GetData();
        int rapport;

        switch (job)
        {
            case shop.Aliment:
                rapport = EvaluateAliment();
                break;

            case shop.Service:
                rapport = EvaluateService();
                break;

            case shop.Velo:
                rapport = EvaluateVelo();
                break;

            case shop.Vetement:
                rapport = EvaluateVetement();

                break;

            default:
                rapport = 0;
                Debug.LogError("Can't evaluate profit in dvlpnt in evaluate profit");
                break;
        }

        rapport += EvaluateTransportPub();
        rapport += EvaluateReseaux();
        rapport += EvaluateJournaux();

        rapport += EvaluatePrice();

        //max ici 43 ?
        RapportProfit(rapport);
    }

    private void DefinePlace()
    {
        switch (lieu)
        {
            case place.WhiteMontain:
                Place = WhiteMontain;
                break;

            case place.UrbanCity:
                Place = UrbanCity;
                break;

            case place.FenzyFarm:
                Place = FenzyFarm;
                break;

            case place.PalmCoconut:
                Place = PalmCoconut;
                break;
        }
    }

    private int EvaluateAliment() // (Population - commerce) * invest point
    {
        int rapport;
        rapport = ((Place.Habitants - Place.AlimentSurgele) * entreprise.intSurgele);
        rapport += ((Place.Habitants - Place.AlimentLivraison) * entreprise.intLivraison);
        rapport += ((Place.Habitants - Place.AlimentBio) * entreprise.intBio);
        //Max ici : 8
        //min ici : -8

        if (entreprise.intSurgele > 0)
        {
            if (Place.AgeMoyen == 1 || Place.AgeMoyen == 2) rapport += 2 + entreprise.intSurgele;
            if (Place.RPH == 1 || Place.RPH == 2) rapport += 2 + entreprise.intSurgele;

            CJeunes += entreprise.intSurgele;
            CAdultes += entreprise.intSurgele;
            CPauvres += entreprise.intSurgele;
            CMoyens += entreprise.intSurgele;
        }

        if (entreprise.intLivraison > 0)
        {
            if (Place.AgeMoyen == 1 || Place.AgeMoyen == 2) rapport += 2 + entreprise.intLivraison;
            if (Place.RPH == 2 || Place.RPH == 3) rapport += 2 + entreprise.intLivraison;

            CJeunes += entreprise.intLivraison;
            CAdultes += entreprise.intLivraison;
            CMoyens += entreprise.intLivraison;
            CRiches += entreprise.intLivraison;
        }

        if (entreprise.intBio > 0)
        {
            if (Place.AgeMoyen == 2 || Place.AgeMoyen == 3) rapport += 2 + entreprise.intSurgele;
            if (Place.RPH == 2 || Place.RPH == 3) rapport += 2 + entreprise.intBio;

            CAdultes += entreprise.intBio;
            CVieux += entreprise.intBio;
            CMoyens += entreprise.intBio;
            CRiches += entreprise.intBio;
        }
        
        Debug.Log("aliment 2 : " + rapport);
        return rapport;
        //max ici : 28
        //min ici : -8
    }
    private int EvaluateService()
    {
        int rapport;
        rapport = ((Place.Habitants - Place.ServiceAidePerso) * entreprise.intAidePerso);
        rapport += ((Place.Habitants - Place.ServiceProfParticulier) * entreprise.intProfParticulier);
        rapport += ((Place.Habitants - Place.ServiceCoachSport) * entreprise.intCoachSport);
        Debug.Log(rapport + "  : eval commerce service done");

        if (entreprise.intCoachSport > 0)
        {
            if (Place.AgeMoyen == 2) rapport += 2 + entreprise.intCoachSport;
            if (Place.RPH == 2 || Place.RPH == 3) rapport += 2 + entreprise.intCoachSport;

            CAdultes += entreprise.intCoachSport;
            CMoyens += entreprise.intCoachSport;
            CRiches += entreprise.intCoachSport;
        }

        if (entreprise.intProfParticulier > 0)
        {
            if (Place.AgeMoyen == 1) rapport += 2 + entreprise.intProfParticulier;
            if (Place.RPH == 2 || Place.RPH == 3) rapport += 2 + entreprise.intProfParticulier;

            CJeunes += entreprise.intProfParticulier;
            CMoyens += entreprise.intProfParticulier;
            CRiches += entreprise.intProfParticulier;
        }

        if (entreprise.intAidePerso > 0)
        {
            if (Place.AgeMoyen == 3) rapport += 2 + entreprise.intAidePerso;
            rapport += 2 + entreprise.intAidePerso;

            CVieux += entreprise.intAidePerso;
            CPauvres += entreprise.intAidePerso;
            CMoyens += entreprise.intAidePerso;
            CRiches += entreprise.intAidePerso;
        }

        Debug.Log(rapport + "eval service done");
        return rapport;

    }
    private int EvaluateVelo()
    {
        int rapport;
        rapport = ((Place.Habitants - Place.VeloVTT) * entreprise.intVTT);
        rapport += ((Place.Habitants - Place.VeloVille) * entreprise.intVille);
        rapport += ((Place.Habitants - Place.VeloCourse) * entreprise.intCourse);
        Debug.Log("Velo 1 : " + rapport);

        if (entreprise.intVTT > 0)
        {
            if (Place.AgeMoyen == 1) rapport += 2 + entreprise.intVTT;
            if (Place.RPH == 2 || Place.RPH == 3) rapport += 2 + entreprise.intVTT;

            CJeunes += entreprise.intVTT;
            CMoyens += entreprise.intVTT;
            CRiches += entreprise.intVTT;
        }

        if (entreprise.intCourse > 0)
        {
            if (Place.AgeMoyen == 2) rapport += 2 + entreprise.intCourse;
            if (Place.RPH == 2 || Place.RPH == 3) rapport += 2 + entreprise.intCourse;

            CAdultes += entreprise.intCourse;
            CMoyens += entreprise.intCourse;
            CRiches += entreprise.intCourse;
        }


        if (entreprise.intVille > 0)
        {
            rapport += 2 + entreprise.intVille; // touche les jeunes les adultes et les vieux
            if (Place.RPH == 1 || Place.RPH == 2) rapport += 2 + entreprise.intVille;

            CJeunes += entreprise.intVille;
            CAdultes += entreprise.intVille;
            CVieux += entreprise.intVille;
            CPauvres += entreprise.intVille;
            CMoyens += entreprise.intVille;
        }

        return rapport;
    }
    private int EvaluateVetement()
    {
        int rapport;
        rapport = ((Place.Habitants - Place.VetementLuxe) * entreprise.intLuxe);
        rapport += ((Place.Habitants - Place.VetementSport) * entreprise.intSport);
        rapport += ((Place.Habitants - Place.VetementQuotidiens) * entreprise.intQuotidiens);

        Debug.Log("vetement 1 : " + rapport);
        //Max ici : 8
        //min ici : -8

        if (entreprise.intLuxe > 0)
        {
            if (Place.AgeMoyen == 1 || Place.AgeMoyen == 2) rapport += 2 + entreprise.intLuxe;
            if (Place.RPH == 3) rapport += 2 + entreprise.intLuxe;
            // max ici 18
            // min ici -8

            CJeunes += entreprise.intLuxe;
            CAdultes += entreprise.intLuxe;
            CRiches += entreprise.intLuxe;
        }

        if (entreprise.intSport > 0)
        {
            if (Place.AgeMoyen == 1) rapport += 2 + entreprise.intSport;
            if (Place.RPH == 1 || Place.RPH == 2) rapport += 2 + entreprise.intSport;

            CJeunes += entreprise.intSport;
            CPauvres += entreprise.intSport;
            CMoyens += entreprise.intSport;
        }

        if (entreprise.intQuotidiens > 0)
        {
            rapport += 2 + entreprise.intQuotidiens; // touche les jeunes les adultes et les vieux
            if (Place.RPH == 1 || Place.RPH == 2) rapport += 2 + entreprise.intQuotidiens;

            CJeunes += entreprise.intQuotidiens;
            CAdultes += entreprise.intQuotidiens;
            CVieux += entreprise.intQuotidiens;
            CPauvres += entreprise.intQuotidiens;
            CMoyens += entreprise.intQuotidiens;
        }
        return rapport;
    }

    private int EvaluateTransportPub()
    {
        int rapport = 0;

        if (entreprise.GetTransport() > 0 && Place.AgeMoyen == 1 || entreprise.GetTransport() > 0 && Place.AgeMoyen == 2)
        {
            rapport += CJeunes;
            rapport += CAdultes;
        }

        if (entreprise.GetNewsLetters() > 0 && Place.AgeMoyen == 2) rapport += 1 + CAdultes;
        if (entreprise.GetBoiteAuLettre() > 0 && Place.AgeMoyen == 3) rapport += CVieux;

        return rapport;
    }
    private int EvaluateReseaux()
    {
        int rapport = 0;

        if (entreprise.GetFakebook() > 0 && Place.AgeMoyen == 2 || entreprise.GetFakebook() > 0 && Place.AgeMoyen == 3)
        {
            rapport += 2 + CAdultes;
            rapport += 2 + CVieux;
        }

        if (entreprise.GetYourTube() > 0 && Place.AgeMoyen == 1 || entreprise.GetYourTube() > 0 && Place.AgeMoyen == 2)
        {
            rapport += 2 + CJeunes;
            rapport += 2 + CAdultes;
        }

        if (entreprise.GetAmstramgram() > 0 && Place.AgeMoyen == 1) rapport += 2 + CJeunes;

        return rapport;
    }
    private int EvaluateJournaux()
    {
        int rapport = 0;

        if (entreprise.GetMagTele() > 0 && Place.AgeMoyen == 2) rapport += 2 + CAdultes;
        if (entreprise.GetLiberte() > 0 && Place.AgeMoyen == 1 || entreprise.GetLiberte() > 0 && Place.AgeMoyen == 2)
        {
            rapport += 2 + CJeunes;
            rapport += 2 + CAdultes;
        }
        if (entreprise.GetSVJ() > 0 && Place.AgeMoyen == 3) rapport += CVieux;

        return rapport;
    }

    private int EvaluatePrice()
    {
        int rapport = 0;
        int[] prix = entreprise.GetPrice();
        int sousMetier1Prix = prix[0];
        int sousMetier2Prix = prix[1];
        int sousMetier3Prix = prix[2];

        if (sousMetier1Prix == Place.RPH) rapport += 2;
        if (sousMetier2Prix == Place.RPH) rapport += 2;
        if (sousMetier3Prix == Place.RPH) rapport += 2;

        if (sousMetier1Prix == 1 || sousMetier2Prix == 1 || sousMetier3Prix == 1) rapport += CPauvres;
        if (sousMetier1Prix == 2 || sousMetier2Prix == 2 || sousMetier3Prix == 2) rapport += CMoyens;
        if (sousMetier1Prix == 3 || sousMetier2Prix == 3 || sousMetier3Prix == 3) rapport += CRiches;
        // +15 max ici
        return rapport;

    }

    private void RapportProfit(int rapport)
    {
        //Max : 43 / Minimum : -8
        Debug.Log("Profit actuelle : " + rapport + "\nMétier : " + job);
        ProfitSlider.value = rapport;

        //Gérer texte robot ?
    }
}
