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
    private Marche Concurrent;

    private RestauType restauType;
    private VeloType veloType;
    private CoachType coachType;
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
        restauType = entreprise.GetRestauType();
        vetementType = entreprise.GetVetementType();
        coachType = entreprise.GetCoachType();
        veloType = entreprise.GetVeloType();

        Debug.Log(entreprise.lieu);
    }


    public void EvaluateProfit()
    {
        switch (job)
        {
            case shop.Restau:
                EvaluateRestau();
                break;
        }
    }

    public void WhichPlace()
    {
        
    }

    private void EvaluateRestau()
    {

    }
}
