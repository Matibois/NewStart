using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evenement : MonoBehaviour
{
    private string[] alimentairePositive;
    private string[] alimentaireNegative;

    private string[] servicePositive;
    private string[] serviceNegative;

    private string[] VeloPositive;
    private string[] VeloNegative;

    private string[] vetementPositive;
    private string[] vetementNegative;

    #region event_text

    public const string titreSurgelePositifEvent = "P�nurie de Frais";
    public const string titreSurgeleNegatifEvent = "Surgel� vs �cologie";

    #endregion
    void Start()
    {
        InitFoodArray();
        InitServiceArray();
        InitVeloArray();
        InitVetementArray();

    }
    public string GetFoodPositive()
    {
        return alimentairePositive[RandomNumber()];
    }
    public string GetFoodNegative()
    {
        return alimentaireNegative[RandomNumber()];
    }
    public string GetServicePositive()
    {
        return servicePositive[RandomNumber()];
    }
    public string GetServiceNegative()
    {
        return serviceNegative[RandomNumber()];
    }
    public string GetVeloPositive()
    {
        return VeloPositive[RandomNumber()];
    }
    public string GetVeloNegative()
    {
        return VeloNegative[RandomNumber()];
    }
    public string GetVetementPositive()
    {
        return vetementPositive[RandomNumber()];
    }
    public string GetVetementNegative()
    {
        return vetementNegative[RandomNumber()];
    }

    private int RandomNumber()
    {
        return Random.Range(0,3);
    }
    private void InitFoodArray()
    {
        alimentairePositive = new string[] {
            "Crise de production de produit frais",
            "Excellente r�colte gr�ce � une m�t�o propice",
            "Confinement",
            };

        alimentaireNegative= new string[] {
            "Pomme",
            "Banane",
            "Orange",
            };
    }
    private void InitServiceArray()
    {
        servicePositive = new string[]
        {
            "Pomme",
            "Banane",
            "Orange",
            };

        serviceNegative = new string[]
        {
            "Pomme",
            "Banane",
            "Orange",
            };
    }
    private void InitVeloArray()
    {
        VeloPositive = new string[]
        {
            "Pomme",
            "Banane",
            "Orange",
            };

        VeloNegative = new string[]
        {
            "Pomme",
            "Banane",
            "Orange",
            };
    }
    private void InitVetementArray()
    {
        vetementPositive = new string[]
        {
            "Pomme",
            "Banane",
            "Orange",
            };

        vetementNegative = new string[]
        {
            "Pomme",
            "Banane",
            "Orange",
            };
    }
}
