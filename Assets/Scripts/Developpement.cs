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
        switch (job)
        {
            case shop.Aliment:
                EvaluateAliment();
                break;
            case shop.Service:
                EvaluateService();
                break;
            case shop.Velo:
                EvaluateVelo();
                break;
            case shop.Vetement:
                EvaluateVetement(); 
                break;
        }
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
        int rapportAliment;
        rapportAliment = ((Place.AlimentSurgele - Place.Habitants) * entreprise.intSurgele);
        rapportAliment += ((Place.AlimentLivraison - Place.Habitants) * entreprise.intLivraison);
        rapportAliment += ((Place.AlimentBio - Place.Habitants) * entreprise.intBio); 

        if (entreprise.intSurgele > 0 && Place.AgeMoyen == 1 && Place.AgeMoyen == 2) 
    }
    
    private void EvaluateService()
    {
        int rapportService;
        rapportService = ((Place.ServiceAidePerso - Place.Habitants) * entreprise.intAidePerso);
        rapportService += ((Place.ServiceProfParticulier- Place.Habitants) * entreprise.intProfParticulier);
        rapportService += ((Place.ServiceCoachSport- Place.Habitants) * entreprise.intCoachSport); 
    }
    
    private void EvaluateVelo()
    {
        int rapportVelo;
        rapportVelo = ((Place.VeloVTT- Place.Habitants) * entreprise.intVTT);
        rapportVelo += ((Place.VeloVille - Place.Habitants) * entreprise.intVille);
        rapportVelo += ((Place.VeloCourse - Place.Habitants) * entreprise.intCourse); 
    }
    
    private void EvaluateVetement()
    {
        int rapportVetement;
        rapportVetement = ((Place.VetementLuxe - Place.Habitants) * entreprise.intLuxe);
        rapportVetement += ((Place.VetementSport - Place.Habitants) * entreprise.intSport);
        rapportVetement += ((Place.VetementQuotidiens - Place.Habitants) * entreprise.intQuotidiens);
        //min (1 - 3) * 3 = -6 -> -18
        ///max (3-1) * 3 = 6 -> 18 
        ///0 (2-2) * 0 
        ///
    }

  

    private void RapportProfit(float rapport)
    {
        //Texte robot catégorie bien choisis ?
        // Gérer slider 
        //Max value 18 // min -18
        // Faire un +18 avec max 36 min 0 et average 18 ?
    }
}
