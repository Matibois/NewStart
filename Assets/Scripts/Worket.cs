using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Worket : MonoBehaviour
{
    [SerializeField] Text textMeshPro;
    public Marche WhiteMontain;
    public Marche PalmCoconut;
    public Marche FenzyFarm;
    public Marche UrbanCity;
   
    Entreprise oui ;
    void Start()
    {
        WhiteMontain = new Marche();
        PalmCoconut = new Marche();
        FenzyFarm = new Marche();
        UrbanCity = new Marche();
        textMeshPro.text = "" + WhiteMontain.RestauNBR + " g" + WhiteMontain.VeloNBR+ "g " + WhiteMontain.CoachNBR + "f " + WhiteMontain.Habitants + " z" + WhiteMontain.RPH+"j";
        
       
        //textMeshPro.text = + " " + WhiteMontain.AgeMoyen;
        //textMeshPro.text = + " " + WhiteMontain.VetementLuxe;
    }

    private void Update()
    {
        //textMeshPro.text = oui.GetUserName();
    }

    public Marche GetWhiteMontain()
    {
        return WhiteMontain;
    }
    public Marche GetFenzyFarm()
    {
        return FenzyFarm;
    }
    public Marche GetPalmCoconut()
    {
        return PalmCoconut;
    }
    public Marche GetUrbanCity()
    {
        return UrbanCity;
    }
}