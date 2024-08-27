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

    private Marche marketPlace;
    private Marche concurrent;

    private Place lieu;
    private Shop job;

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
            case Shop.Aliment:
                rapport = EvaluateAliment();
                break;

            case Shop.Service:
                rapport = EvaluateService();
                break;

            case Shop.Velo:
                rapport = EvaluateVelo();
                break;

            case Shop.Vetement:
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
            case Place.WhiteMontain:
                marketPlace = WhiteMontain;
                break;

            case Place.UrbanCity:
                marketPlace = UrbanCity;
                break;

            case Place.FenzyFarm:
                marketPlace = FenzyFarm;
                break;

            case Place.PalmCoconut:
                marketPlace = PalmCoconut;
                break;
        }
    }

    private int EvaluateAliment() // (Population - commerce) * invest point
    {
        int rapport;
        rapport = ((marketPlace.Habitants - marketPlace.AlimentSurgele) * entreprise.intSurgele);
        rapport += ((marketPlace.Habitants - marketPlace.AlimentLivraison) * entreprise.intLivraison);
        rapport += ((marketPlace.Habitants - marketPlace.AlimentBio) * entreprise.intBio);
        //Max ici : 8
        //min ici : -8

        if (entreprise.intSurgele > 0)
        {
            if (marketPlace.AgeMoyen == 1 || marketPlace.AgeMoyen == 2) rapport += 2 + entreprise.intSurgele;
            if (marketPlace.RPH == 1 || marketPlace.RPH == 2) rapport += 2 + entreprise.intSurgele;

            CJeunes += entreprise.intSurgele;
            CAdultes += entreprise.intSurgele;
            CPauvres += entreprise.intSurgele;
            CMoyens += entreprise.intSurgele;
        }

        if (entreprise.intLivraison > 0)
        {
            if (marketPlace.AgeMoyen == 1 || marketPlace.AgeMoyen == 2) rapport += 2 + entreprise.intLivraison;
            if (marketPlace.RPH == 2 || marketPlace.RPH == 3) rapport += 2 + entreprise.intLivraison;

            CJeunes += entreprise.intLivraison;
            CAdultes += entreprise.intLivraison;
            CMoyens += entreprise.intLivraison;
            CRiches += entreprise.intLivraison;
        }

        if (entreprise.intBio > 0)
        {
            if (marketPlace.AgeMoyen == 2 || marketPlace.AgeMoyen == 3) rapport += 2 + entreprise.intSurgele;
            if (marketPlace.RPH == 2 || marketPlace.RPH == 3) rapport += 2 + entreprise.intBio;

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
        rapport = ((marketPlace.Habitants - marketPlace.ServiceAidePerso) * entreprise.intAidePerso);
        rapport += ((marketPlace.Habitants - marketPlace.ServiceProfParticulier) * entreprise.intProfParticulier);
        rapport += ((marketPlace.Habitants - marketPlace.ServiceCoachSport) * entreprise.intCoachSport);
        Debug.Log(rapport + "  : eval commerce service done");

        if (entreprise.intCoachSport > 0)
        {
            if (marketPlace.AgeMoyen == 2) rapport += 2 + entreprise.intCoachSport;
            if (marketPlace.RPH == 2 || marketPlace.RPH == 3) rapport += 2 + entreprise.intCoachSport;

            CAdultes += entreprise.intCoachSport;
            CMoyens += entreprise.intCoachSport;
            CRiches += entreprise.intCoachSport;
        }

        if (entreprise.intProfParticulier > 0)
        {
            if (marketPlace.AgeMoyen == 1) rapport += 2 + entreprise.intProfParticulier;
            if (marketPlace.RPH == 2 || marketPlace.RPH == 3) rapport += 2 + entreprise.intProfParticulier;

            CJeunes += entreprise.intProfParticulier;
            CMoyens += entreprise.intProfParticulier;
            CRiches += entreprise.intProfParticulier;
        }

        if (entreprise.intAidePerso > 0)
        {
            if (marketPlace.AgeMoyen == 3) rapport += 2 + entreprise.intAidePerso;
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
        rapport = ((marketPlace.Habitants - marketPlace.VeloVTT) * entreprise.intVTT);
        rapport += ((marketPlace.Habitants - marketPlace.VeloVille) * entreprise.intVille);
        rapport += ((marketPlace.Habitants - marketPlace.VeloCourse) * entreprise.intCourse);
        Debug.Log("Velo 1 : " + rapport);

        if (entreprise.intVTT > 0)
        {
            if (marketPlace.AgeMoyen == 1) rapport += 2 + entreprise.intVTT;
            if (marketPlace.RPH == 2 || marketPlace.RPH == 3) rapport += 2 + entreprise.intVTT;

            CJeunes += entreprise.intVTT;
            CMoyens += entreprise.intVTT;
            CRiches += entreprise.intVTT;
        }

        if (entreprise.intCourse > 0)
        {
            if (marketPlace.AgeMoyen == 2) rapport += 2 + entreprise.intCourse;
            if (marketPlace.RPH == 2 || marketPlace.RPH == 3) rapport += 2 + entreprise.intCourse;

            CAdultes += entreprise.intCourse;
            CMoyens += entreprise.intCourse;
            CRiches += entreprise.intCourse;
        }


        if (entreprise.intVille > 0)
        {
            rapport += 2 + entreprise.intVille; // touche les jeunes les adultes et les vieux
            if (marketPlace.RPH == 1 || marketPlace.RPH == 2) rapport += 2 + entreprise.intVille;

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
        rapport = ((marketPlace.Habitants - marketPlace.VetementLuxe) * entreprise.intLuxe);
        rapport += ((marketPlace.Habitants - marketPlace.VetementSport) * entreprise.intSport);
        rapport += ((marketPlace.Habitants - marketPlace.VetementQuotidiens) * entreprise.intQuotidiens);

        Debug.Log("vetement 1 : " + rapport);
        //Max ici : 8
        //min ici : -8

        if (entreprise.intLuxe > 0)
        {
            if (marketPlace.AgeMoyen == 1 || marketPlace.AgeMoyen == 2) rapport += 2 + entreprise.intLuxe;
            if (marketPlace.RPH == 3) rapport += 2 + entreprise.intLuxe;
            // max ici 18
            // min ici -8

            CJeunes += entreprise.intLuxe;
            CAdultes += entreprise.intLuxe;
            CRiches += entreprise.intLuxe;
        }

        if (entreprise.intSport > 0)
        {
            if (marketPlace.AgeMoyen == 1) rapport += 2 + entreprise.intSport;
            if (marketPlace.RPH == 1 || marketPlace.RPH == 2) rapport += 2 + entreprise.intSport;

            CJeunes += entreprise.intSport;
            CPauvres += entreprise.intSport;
            CMoyens += entreprise.intSport;
        }

        if (entreprise.intQuotidiens > 0)
        {
            rapport += 2 + entreprise.intQuotidiens; // touche les jeunes les adultes et les vieux
            if (marketPlace.RPH == 1 || marketPlace.RPH == 2) rapport += 2 + entreprise.intQuotidiens;

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

        if (entreprise.GetTransport() > 0 && marketPlace.AgeMoyen == 1 || entreprise.GetTransport() > 0 && marketPlace.AgeMoyen == 2)
        {
            rapport += CJeunes;
            rapport += CAdultes;
        }

        if (entreprise.GetNewsLetters() > 0 && marketPlace.AgeMoyen == 2) rapport += 1 + CAdultes;
        if (entreprise.GetBoiteAuLettre() > 0 && marketPlace.AgeMoyen == 3) rapport += CVieux;

        return rapport;
    }
    private int EvaluateReseaux()
    {
        int rapport = 0;

        if (entreprise.GetFakebook() > 0 && marketPlace.AgeMoyen == 2 || entreprise.GetFakebook() > 0 && marketPlace.AgeMoyen == 3)
        {
            rapport += 2 + CAdultes;
            rapport += 2 + CVieux;
        }

        if (entreprise.GetYourTube() > 0 && marketPlace.AgeMoyen == 1 || entreprise.GetYourTube() > 0 && marketPlace.AgeMoyen == 2)
        {
            rapport += 2 + CJeunes;
            rapport += 2 + CAdultes;
        }

        if (entreprise.GetAmstramgram() > 0 && marketPlace.AgeMoyen == 1) rapport += 2 + CJeunes;

        return rapport;
    }
    private int EvaluateJournaux()
    {
        int rapport = 0;

        if (entreprise.GetMagTele() > 0 && marketPlace.AgeMoyen == 2) rapport += 2 + CAdultes;
        if (entreprise.GetLiberte() > 0 && marketPlace.AgeMoyen == 1 || entreprise.GetLiberte() > 0 && marketPlace.AgeMoyen == 2)
        {
            rapport += 2 + CJeunes;
            rapport += 2 + CAdultes;
        }
        if (entreprise.GetSVJ() > 0 && marketPlace.AgeMoyen == 3) rapport += CVieux;

        return rapport;
    }

    private int EvaluatePrice()
    {
        int rapport = 0;
        int[] prix = entreprise.GetPrice();
        int sousMetier1Prix = prix[0];
        int sousMetier2Prix = prix[1];
        int sousMetier3Prix = prix[2];

        if (sousMetier1Prix == marketPlace.RPH) rapport += 2;
        if (sousMetier2Prix == marketPlace.RPH) rapport += 2;
        if (sousMetier3Prix == marketPlace.RPH) rapport += 2;

        if (sousMetier1Prix == 1 || sousMetier2Prix == 1 || sousMetier3Prix == 1) rapport += CPauvres;
        if (sousMetier1Prix == 2 || sousMetier2Prix == 2 || sousMetier3Prix == 2) rapport += CMoyens;
        if (sousMetier1Prix == 3 || sousMetier2Prix == 3 || sousMetier3Prix == 3) rapport += CRiches;
        // +15 max ici
        return rapport;

    }

    public void EventImpact(int rapport)
    {
       Profit += rapport;
    }

    private void RapportProfit(int rapport)
    {
        //Max : 43 / Minimum : -8
        Debug.Log("Profit actuelle : " + rapport + "\nMétier : " + job);
        Profit = rapport;

        //Gérer texte robot ?
    }
}
