using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Entreprise;

public class Developpement : MonoBehaviour
{
    
    public GameObject marche;
    public GameObject profil;
    private Entreprise entreprise;

    [SerializeField] public Worket worket;
    [SerializeField] public Marche WhiteMontain;
    [SerializeField] public Marche PalmCoconut;
    [SerializeField] public Marche FenzyFarm;
    [SerializeField] public Marche UrbanCity;

    public string UserName;
    public int Money;
    public place Lieu;
    public shop Shop;
    public RestauType RestauType;
    public VeloType VeloType;
    public CoachType CoachType;
    public VetementType VetementType;

    private void Start()
    {
        worket = GetComponent<Worket>();
        worket.initiateWorket(worket);
        entreprise.lieu = entreprise.GetPlace();
        entreprise.job = entreprise.GetShop();
        entreprise.restauType = entreprise.GetRestauType();
        entreprise.vetementType = entreprise.GetVetementType();
        entreprise.coachType = entreprise.GetCoachType();
        entreprise.veloType = entreprise.GetVeloType();
        Debug.Log("entreprise.lieu");
        Debug.Log("hab wh dvlpt : " + worket.WhiteMontain.Habitants);
    }

}
