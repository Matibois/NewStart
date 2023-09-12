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
    }


    public void EvaluateProfit()
    {
        /*switch (job)
        {
            case shop.Aliment:
                EvaluateAliment();
                break;
        }*/
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

    private void EvaluateAliment(AlimentType alimentType)
    {
        int profit;

         switch (alimentType)
         {
             case AlimentType.Surgele:
                RapportTest(Place.AlimentSurgele - Place.Habitants); 
                break;
         }


    }

    private void RapportTest(float rapport)
    {
        /*switch (rapport)
        {
            case 0:

                Break;
            case 1:

                Break;
            case 2:

                Break;

        }*/
    }
}
