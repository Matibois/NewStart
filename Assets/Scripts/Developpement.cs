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
                break;
            case shop.Velo:
                break;
            case shop.Vetement:
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

    private void EvaluateAliment()
    {
        int rapportAliment;
        rapportAliment = ((Place.AlimentSurgele - Place.Habitants) * entreprise.intSurgele);
        rapportAliment += ((Place.AlimentLivraison - Place.Habitants) * entreprise.intLivraison);
        rapportAliment += ((Place.AlimentBio - Place.Habitants) * entreprise.intBio);

        
    }

  

    private void RapportTest(float rapport)
    {
        //Texte robot catégorie bien choisis ?
        switch (rapport)
        {
            case 0:

                break;
            case 1:

                break;
            case 2:

                break;

        }
    }
}
