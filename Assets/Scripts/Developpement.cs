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

    public void GeteData()
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
        GeteData();
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
                rapport = 22;
                Debug.LogError("chips");
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

    private int EvaluateAliment() // nombre de commerce existant dans le lieu moins population * le nombre de point investie dans le commerce
    {
        int rapport;
        rapport = ((Place.Habitants - Place.AlimentSurgele) * entreprise.intSurgele);
        rapport += ((Place.Habitants - Place.AlimentLivraison) * entreprise.intLivraison);
        rapport += ((Place.Habitants - Place.AlimentBio) * entreprise.intBio);

        if (entreprise.intSurgele > 0 && Place.AgeMoyen == 1 || entreprise.intSurgele > 0 && Place.AgeMoyen == 2) rapport += 2 + entreprise.intSurgele;
        if (entreprise.intLivraison > 0 && Place.AgeMoyen == 1) rapport += 2 + entreprise.intLivraison;
        if (entreprise.intBio > 0 && Place.AgeMoyen == 2 || entreprise.intBio > 0 && Place.AgeMoyen == 3) rapport += 2 + entreprise.intBio;

        if (entreprise.intSurgele > 0 && Place.RPH == 1 || entreprise.intSurgele > 0 && Place.RPH == 2) rapport += 2 + entreprise.intSurgele;
        if (entreprise.intLivraison > 0 && Place.RPH == 2 || entreprise.intLivraison > 0 && Place.RPH == 3) rapport += 2 + entreprise.intLivraison;
        if (entreprise.intBio > 0) rapport += 2 + entreprise.intBio; //Car ça touche les pauvres les moyens et les riches

        return rapport;
    }

    private int EvaluateService()
    {
        int rapport;
        rapport = ((Place.Habitants - Place.ServiceAidePerso) * entreprise.intAidePerso);
        rapport += ((Place.Habitants - Place.ServiceProfParticulier) * entreprise.intProfParticulier);
        rapport += ((Place.Habitants - Place.ServiceCoachSport) * entreprise.intCoachSport);

        if (entreprise.intCoachSport > 0 && Place.AgeMoyen == 2) rapport += 2 + entreprise.intCoachSport;
        if (entreprise.intProfParticulier > 0 && Place.AgeMoyen == 1) rapport += 2 + entreprise.intProfParticulier;
        if (entreprise.intAidePerso > 0 && Place.AgeMoyen == 3) rapport += 2 + entreprise.intAidePerso;

        if (entreprise.intCoachSport > 0 && Place.RPH == 2 || entreprise.intCoachSport > 0 && Place.RPH == 3) rapport += 2 + entreprise.intCoachSport;
        if (entreprise.intProfParticulier > 0 && Place.RPH == 2 || entreprise.intProfParticulier > 0 && Place.RPH == 3) rapport += 2 + entreprise.intProfParticulier;
        if (entreprise.intAidePerso > 0) rapport += 2 + entreprise.intAidePerso; //Car ça touche les pauvres les moyens et les riches

        return rapport;

    }

    private int EvaluateVelo()
    {
        int rapport;
        rapport = ((Place.Habitants - Place.VeloVTT) * entreprise.intVTT);
        rapport += ((Place.Habitants - Place.VeloVille) * entreprise.intVille);
        rapport += ((Place.Habitants - Place.VeloCourse) * entreprise.intCourse);

        if (entreprise.intVTT > 0 && Place.AgeMoyen == 1) rapport += 2 + entreprise.intVTT;
        if (entreprise.intCourse > 0 && Place.AgeMoyen == 2) rapport += 2 + entreprise.intCourse;
        if (entreprise.intVille > 0) rapport += 2 + entreprise.intVille; //Car ça touche les jeunes les adultes et les vieux

        if (entreprise.intVTT > 0 && Place.RPH == 2 || entreprise.intVTT > 0 && Place.RPH == 3) rapport += 2 + entreprise.intVTT;
        if (entreprise.intCourse > 0 && Place.RPH == 2 || entreprise.intCourse > 0 && Place.RPH == 3) rapport += 2 + entreprise.intCourse;
        if (entreprise.intVille > 0 && Place.RPH == 1 || entreprise.intVille > 0 && Place.RPH == 2) rapport += 2 + entreprise.intVille;

        return rapport;

    }

    private int EvaluateVetement()
    {
        int rapport;
        rapport = ((Place.Habitants - Place.VetementLuxe) * entreprise.intLuxe);
        rapport += ((Place.Habitants - Place.VetementSport) * entreprise.intSport);
        rapport += ((Place.Habitants - Place.VetementQuotidiens) * entreprise.intQuotidiens);


        if (entreprise.intLuxe > 0 && Place.AgeMoyen == 1 || entreprise.intLuxe > 0 && Place.AgeMoyen == 2) rapport += 2 + entreprise.intLuxe;
        if (entreprise.intSport > 0 && Place.AgeMoyen == 1) rapport += 2 + entreprise.intSport;
        if (entreprise.intQuotidiens > 0) rapport += 2 + entreprise.intQuotidiens;//Car ça touche les jeunes les adultes et les vieux

        if (entreprise.intLuxe > 0 && Place.RPH == 3) rapport += 2 + entreprise.intLuxe;
        if (entreprise.intSport > 0 && Place.RPH == 1 || entreprise.intSport > 0 && Place.RPH == 2) rapport += 2 + entreprise.intSport;
        if (entreprise.intQuotidiens > 0 && Place.RPH == 1 || entreprise.intQuotidiens > 0 && Place.RPH == 2) rapport += 2 + entreprise.intQuotidiens;
        //min  -8
        ///max 8 
        ///24 ?

        return rapport;
    }


    private void RapportProfit(int rapport)
    {
        //Gérer slider
        //Gérer texte robot ?
        ProfitSlider.value = rapport;
        Debug.Log("Profit actuelle : " + rapport + "\nMétier : " + job);
    }
}
