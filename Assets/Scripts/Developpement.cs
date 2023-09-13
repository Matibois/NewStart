using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Entreprise;

public class Developpement : MonoBehaviour
{
    public Slider slider;

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

    private AlimentType alimentType;
    private VeloType veloType;
    private ServiceType ServiceType;
    private VetementType vetementType;
    private place lieu;
    private shop job;

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
        alimentType = entreprise.GetAlimentType();
        vetementType = entreprise.GetVetementType();
        ServiceType = entreprise.GetServiceType();
        veloType = entreprise.GetVeloType();

        DefinePlace();
    }


    public void EvaluateProfit()
    {
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
        }

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

    private void EvaluateAliment() // nombre de commerce existant dans le lieu moins population * le nombre de point investie dans le commerce
    {
        int rapport;
        rapport = ((Place.AlimentSurgele - Place.Habitants) * entreprise.intSurgele);
        rapport += ((Place.AlimentLivraison - Place.Habitants) * entreprise.intLivraison);
        rapport += ((Place.AlimentBio - Place.Habitants) * entreprise.intBio);
        
        if (entreprise.intSurgele > 0 && Place.AgeMoyen == 1 || entreprise.intSurgele > 0  && Place.AgeMoyen == 2) rapport += 5 + entreprise.intSurgele;
        if (entreprise.intLivraison > 0 && Place.AgeMoyen == 1) rapport += 5 + entreprise.intLivraison;
        if (entreprise.intBio > 0 && Place.AgeMoyen == 2 || entreprise.intBio > 0 && Place.AgeMoyen == 3) rapport += 5 + entreprise.intBio;

        if (entreprise.intSurgele > 0 && Place.RPH == 1 || entreprise.intSurgele > 0 && Place.RPH == 2) rapport += 5 + entreprise.intSurgele;
        if (entreprise.intLivraison > 0 && Place.RPH == 2 || entreprise.intLivraison > 0 && Place.RPH == 3) rapport += 5 + entreprise.intLivraison;
        if (entreprise.intBio > 0 ) rapport += 5 + entreprise.intBio; //Car ça touche les pauvres les moyens et les riches

        return rapport;
    }
    
    private void EvaluateService()
    {
        int rapport;
        rapport = ((Place.ServiceAidePerso - Place.Habitants) * entreprise.intAidePerso);
        rapport += ((Place.ServiceProfParticulier- Place.Habitants) * entreprise.intProfParticulier);
        rapport += ((Place.ServiceCoachSport- Place.Habitants) * entreprise.intCoachSport);

        if (entreprise.intCoachSport> 0 && Place.AgeMoyen == 2) rapport += 5 + entreprise.intCoachSport;
        if (entreprise.intProfParticulier> 0 && Place.AgeMoyen == 1) rapport += 5 + entreprise.intProfParticulier;
        if (entreprise.intAidePerso> 0 && Place.AgeMoyen == 3) rapport += 5 + entreprise.intAidePerso;

        if (entreprise.intCoachSport > 0 && Place.RPH == 2 || entreprise.intCoachSport > 0 && Place.RPH == 3) rapport += 5 + entreprise.intCoachSport;
        if (entreprise.intProfParticulier > 0 && Place.RPH == 2 || entreprise.intProfParticulier > 0 && Place.RPH == 3) rapport += 5 + entreprise.intProfParticulier;
        if (entreprise.intAidePerso > 0) rapport += 5 + entreprise.intAidePerso; //Car ça touche les pauvres les moyens et les riches

        return rapport;

    }

    private void EvaluateVelo()
    {
        int rapport;
        rapport = ((Place.VeloVTT- Place.Habitants) * entreprise.intVTT);
        rapport += ((Place.VeloVille - Place.Habitants) * entreprise.intVille);
        rapport += ((Place.VeloCourse - Place.Habitants) * entreprise.intCourse);

        if (entreprise.intVTT> 0 && Place.AgeMoyen == 1) rapport += 5 + entreprise.intVTT;
        if (entreprise.intCourse > 0 && Place.AgeMoyen == 2) rapport += 5 + entreprise.intCourse;
        if (entreprise.intVille > 0) rapport += 5 + entreprise.intVille; //Car ça touche les jeunes les adultes et les vieux

        if (entreprise.intVTT> 0 && Place.RPH == 2 || entreprise.intVTT > 0 && Place.RPH == 3) rapport += 5 + entreprise.intVTT;
        if (entreprise.intCourse > 0 && Place.RPH == 2 || entreprise.intCourse > 0 && Place.RPH == 3 ) rapport += 5 + entreprise.intCourse;
        if (entreprise.intVille > 0 && Place.RPH == 1 || entreprise.intVille > 0 && Place.RPH == 2) rapport += 5 + entreprise.intVille;

        return rapport;

    }

    private void EvaluateVetement()
    {
        int rapport;
        rapport = ((Place.VetementLuxe - Place.Habitants) * entreprise.intLuxe);
        rapport += ((Place.VetementSport - Place.Habitants) * entreprise.intSport);
        rapport+= ((Place.VetementQuotidiens - Place.Habitants) * entreprise.intQuotidiens);

        if (entreprise.intLuxe > 0 && Place.AgeMoyen == 1 && Place.AgeMoyen == 2) rapport += 5 + entreprise.intLuxe;
        if (entreprise.intSport > 0 && Place.AgeMoyen == 1) rapport += 5 + entreprise.intSport;
        if (entreprise.intQuotidiens > 0) rapport += 5 + entreprise.intQuotidiens;//Car ça touche les jeunes les adultes et les vieux

        if (entreprise.intLuxe > 0 && Place.RPH == 3) rapport += 5 + entreprise.intLuxe;
        if (entreprise.intSport > 0 && Place.RPH == 1 && Place.RPH == 2) rapport += 5 + entreprise.intSport;
        if (entreprise.intQuotidiens > 0 && Place.RPH == 1 || entreprise.intQuotidiens > 0 && Place.RPH == 2) rapport += 5 + entreprise.intQuotidiens;
        //min  -8
        ///max 8 
        return rapport;
    }



    private void RapportProfit(float rapport)
    {
        //Gérer slider
        //Gérer texte robot

    }
}
