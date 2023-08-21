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

    private int Profit;

    private void Start()
    {
        worket = FindObjectOfType<Worket>();
        worket = worket.initiateWorket(worket);
        entreprise = FindObjectOfType<Entreprise>();

        entreprise.lieu = entreprise.GetPlace();
        entreprise.job = entreprise.GetShop();
        entreprise.restauType = entreprise.GetRestauType();
        entreprise.vetementType = entreprise.GetVetementType();
        entreprise.coachType = entreprise.GetCoachType();
        entreprise.veloType = entreprise.GetVeloType();
        Debug.Log(entreprise.lieu);
    }


    public void EvaluateProfit()
    {
        switch (entreprise.job)
        {
            case shop.Restau:
                EvaluateRestau();
                break;
        }
    }

    private void EvaluateRestau()
    {

    }
}
