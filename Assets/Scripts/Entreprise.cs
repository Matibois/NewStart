using System.IO;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static Entreprise;
using UnityEngine.Rendering.Universal;

[System.Serializable]
public class Entreprise : MonoBehaviour
{
    [SerializeField] TMP_InputField NameEntry; 
    [SerializeField] TMP_Text NameText;
    [SerializeField] TMP_Text PosText;
    [SerializeField] TMP_Text PlaceText;
    [SerializeField] TMP_Text JobText;

    public TMP_Dropdown JobDB;
    [SerializeField] GameObject RestauDB;
    [SerializeField] GameObject VeloDB;
    [SerializeField] GameObject CoachDB;
    [SerializeField] GameObject VetementDB;

    public enum place
    {
        WhiteMontain,
        PalmCoconut,
        UrbanCity,
        FenzyFarm,
    }
    public enum shop
    {
        Restau,
        Vélo,
        Coach,
        Vetement,
    }
    public enum RestauType
    {
        Luxe,
        EcoLocal,
        FastFood,
    }
    public enum VeloType
    {
        Course,
        VTT,
        Electrique,
    }
    public enum CoachType
    {
        Sport,
        Entreprise,
        SelfDeveloppement,
    }
    public enum VetementType
    {
        Luxe,
        Sport,
        TechWear,
    }

    [SerializeField] public string UserName;
    [SerializeField] public shop job;
    [SerializeField] public int Money;
    [SerializeField] public int TypeChoice;
    [SerializeField] public place lieu;

    [SerializeField] public RestauType restauType;
    [SerializeField] public VeloType veloType;
    [SerializeField] public CoachType coachType;
    [SerializeField] public VetementType vetementType;
    TMP_Dropdown jobtype;

    public SaveData saveData;

    private void Awake()
    {
        saveData = new SaveData();
    }

    public void Named()
    {
        UserName = NameEntry.text;
        NameText.text = UserName;
    }
    
    public void jobChoice()
    {        
        switch (JobDB.value)
        {
            case 0:
                job = shop.Restau;
                JobText.text = "Restaurateur";
                RestauDB.SetActive(true);
                VeloDB.SetActive(false);
                CoachDB.SetActive(false);
                VetementDB.SetActive(false);
                jobtype = RestauDB.GetComponent<TMP_Dropdown>();
                break;
            
            case 1:
                job = shop.Vélo;
                JobText.text = "Magasin de vélo";
                VeloDB.SetActive(true);
                CoachDB.SetActive(false);
                VetementDB.SetActive(false);
                RestauDB.SetActive(false);
                jobtype = VeloDB.GetComponent<TMP_Dropdown>();
                break;

            case 2:
                job = shop.Coach;
                JobText.text = "Coach";
                CoachDB.SetActive(true);
                VeloDB.SetActive(false);
                RestauDB.SetActive(false);
                VetementDB.SetActive(false);

                jobtype = CoachDB.GetComponent<TMP_Dropdown>();
                break;
            
            case 3:
                job = shop.Vetement;
                JobText.text = "Magasin de vetement";
                VetementDB.SetActive(true);
                VeloDB.SetActive(false);
                CoachDB.SetActive(false);
                RestauDB.SetActive(false);
                jobtype = VetementDB.GetComponent<TMP_Dropdown>();
                break;
        }
    }

    public void PosChoice()
    {
        switch (job)
        {
            case shop.Restau:
                switch (jobtype.value)
                {
                    case 0:
                        restauType = RestauType.Luxe;
                        PosText.text = "Luxe";
                        break;

                    case 1:
                        restauType = RestauType.EcoLocal;
                        PosText.text = "Bio local";
                        break;

                    case 2:
                        restauType = RestauType.FastFood;
                        PosText.text = "Fast Food";
                        break;
                }
                break;

            case shop.Vélo:
                switch (jobtype.value)
                {
                    case 0:
                        veloType = VeloType.Course;
                        PosText.text = "Courses";
                        break;

                    case 1:
                        veloType = VeloType.VTT;
                        PosText.text = "VTT";
                        break;

                    case 2:
                        veloType = VeloType.Electrique;
                        PosText.text = "Electric";
                        break;
                }
                break;

            case shop.Coach:
                switch (jobtype.value)
                {
                    case 0:
                        coachType = CoachType.Sport;
                        PosText.text = "Sport";
                        break;

                    case 1:
                        coachType = CoachType.Entreprise;
                        PosText.text = "Entreprise";
                        break;

                    case 2:
                        coachType = CoachType.SelfDeveloppement;
                        PosText.text = "Self developpement";
                        break;
                }
                break;

            case shop.Vetement:
                switch (jobtype.value)
                {
                    case 0:
                        vetementType = VetementType.Luxe;
                        PosText.text = "Luxe";
                        break;

                    case 1:
                        vetementType = VetementType.Sport;
                        PosText.text = "Sport";
                        break;

                    case 2:
                        vetementType = VetementType.TechWear;
                        PosText.text = "Tech Wear";
                        break;
                }
                break;
        }
    }
    

    public void ErasePlace()
    {
        PlaceText.text = string.Empty;
    }
    public void EraseJob()
    {
        JobText.text = string.Empty;
        PosText.text = string.Empty;
    }

    public void MontainPlace()
    {
        lieu = place.WhiteMontain;
        PlaceText.text = "White Montain";
    }
    public void CityPlace()
    {
        lieu = place.UrbanCity;
        PlaceText.text = "Urban City";
    }
    public void PalmPlace()
    {
        lieu = place.PalmCoconut;
        PlaceText.text = "Palm Coconut";
    }
    public void FarmPlace()
    {
        lieu = place.FenzyFarm;
        PlaceText.text = "Fenzy Farm";
    }

    public string GetUserName()
    {
        return UserName;
    }

    public int GetMoney() { return Money; }
    public shop GetShop() { return job; }

    public place GetPlace() { return lieu; }
    public RestauType GetRestauType() { return restauType; }
    public VeloType GetVeloType() { return veloType; }
    public CoachType GetCoachType() {  return coachType; }
    public VetementType GetVetementType() { return vetementType; }

    public void RefreshScreen()
    {

    }

    public void Load1()
    {
        string savePath = Application.persistentDataPath + "/sauvegarde1.json";

        if (File.Exists(savePath))
        {
            string jsonData = File.ReadAllText(savePath);

            SaveData saveData = new SaveData();
            JsonUtility.FromJsonOverwrite(jsonData, saveData);

            // Mettez à jour les valeurs de la classe Entreprise avec les données désérialisées
            UserName = saveData.UserName;
            Money = saveData.Money;
            lieu = saveData.Lieu;
            job = saveData.Shop;
            restauType = saveData.RestauType;
            veloType = saveData.VeloType;
            coachType = saveData.CoachType;
            vetementType = saveData.VetementType;
            
            RefreshScreen();
            Debug.Log("Chargement réussi depuis le fichier JSON " + savePath);
        }
        else
        {
            Debug.LogError("Le fichier de sauvegarde n'existe pas.");
        }
    }
}


