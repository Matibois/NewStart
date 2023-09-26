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
    [SerializeField] TMP_InputField EntrepriseNameEntry;
    [SerializeField] TMP_Text NameText;
    [SerializeField] TMP_Text EntrepriseNameText;
    [SerializeField] TMP_Text PosText;
    [SerializeField] TMP_Text PlaceText;
    [SerializeField] TMP_Text JobText;
    [SerializeField] TMP_Text SousMetier1Text;
    [SerializeField] TMP_Text SousMetier2Text;
    [SerializeField] TMP_Text SousMetier3Text;

    public TMP_Dropdown JobDB;
    [SerializeField] GameObject ValidateJobBtn;

    [SerializeField] public string UserName;
    [SerializeField] public string EntrepriseName;
    [SerializeField] public shop job;
    [SerializeField] public int Money;
    [SerializeField] public int TypeChoice;
    [SerializeField] public place lieu;

    TMP_Dropdown jobtype;

    [SerializeField] public int intSurgele;
    [SerializeField] public int intLivraison;
    [SerializeField] public int intBio;

    [SerializeField] public int intCourse;
    [SerializeField] public int intVTT;
    [SerializeField] public int intVille;

    [SerializeField] public int intAidePerso;
    [SerializeField] public int intProfParticulier;
    [SerializeField] public int intCoachSport;

    [SerializeField] public int intLuxe;
    [SerializeField] public int intSport;
    [SerializeField] public int intQuotidiens;

    public int SousMetier1;
    public int SousMetier2;
    public int SousMetier3;
    private int sousMetierPoint = 4;

    [SerializeField] public int intTransport;
    [SerializeField] public int intNewsLetters;
    [SerializeField] public int intBoiteAuLettre;

    [SerializeField] public int intFakebook;
    [SerializeField] public int intYourTube;
    [SerializeField] public int intAmstramgram;

    [SerializeField] public int intMagTele;
    [SerializeField] public int intLiberte;
    [SerializeField] public int intSVJ;

    public enum place
    {
        WhiteMontain,
        PalmCoconut,
        UrbanCity,
        FenzyFarm,
    }
    public enum shop
    {
        Aliment,
        Velo,
        Service,
        Vetement,
    }

    public SaveData saveData;
    [SerializeField] private GestionnaireUI gestionnaireUI;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void Named(string name)
    {
        UserName = name;
    }

    public void JobChoice()
    {
        switch (JobDB.value)
        {
            case 1:
                job = shop.Aliment;
                JobText.text = "Magasin alimentaire";
                ValidateJobBtn.SetActive(true);
                SousMetier1 = intSurgele;
                SousMetier2 = intBio;
                SousMetier3 = intLivraison;
                break;

            case 2:
                job = shop.Velo;
                JobText.text = "Magasin de Velo";
                ValidateJobBtn.SetActive(true);
                SousMetier1 = intVTT;
                SousMetier2 = intCourse;
                SousMetier3 = intVille;
                break;

            case 3:
                job = shop.Service;
                JobText.text = "Service Personnelle";
                ValidateJobBtn.SetActive(true);
                SousMetier1 = intAidePerso;
                SousMetier2 = intCoachSport;
                SousMetier3 = intProfParticulier;
                break;

            case 4:
                job = shop.Vetement;
                JobText.text = "Magasin de vetement";
                ValidateJobBtn.SetActive(true);
                SousMetier1 = intLuxe;
                SousMetier2 = intSport;
                SousMetier3 = intQuotidiens;
                break;

            case 0:
                ValidateJobBtn.SetActive(false);
                JobText.text = " ";
                break;
        }
    }

    public void SousMetierAddPoint(int sousMetier)
    {
        if (sousMetierPoint > 0)
        {
            switch (sousMetier)
            {
                case 1:
                    if (SousMetier1 < 3)
                    {
                        SousMetier1++;
                        sousMetierPoint--;
                        SousMetier1Text.text = SousMetier1.ToString();
                    }
                    break;

                case 2:
                    if (SousMetier2 < 3)
                    {
                        SousMetier2++;
                        sousMetierPoint--;
                        SousMetier2Text.text = SousMetier2.ToString();
                    }
                    break;

                case 3:
                    if (SousMetier3 < 3)
                    {
                        SousMetier3++;
                        sousMetierPoint--;
                        SousMetier3Text.text = SousMetier3.ToString();
                    }
                    break;
            }
            RefreshMetierPoint();
        }
    }
    public void SousMetierRemovePoint(int sousMetier)
    {
        switch (sousMetier)
        {
            case 1:
                if (SousMetier1 > 0)
                {
                    SousMetier1--;
                    sousMetierPoint++;
                    SousMetier1Text.text = SousMetier1.ToString();
                }
                break;

            case 2:
                if (SousMetier2 > 0)
                {
                    SousMetier2--;
                    sousMetierPoint++;
                    SousMetier2Text.text = SousMetier2.ToString();
                }
                break;

            case 3:
                if (SousMetier3 > 0)
                {
                    SousMetier3--;
                    sousMetierPoint++;
                    SousMetier3Text.text = SousMetier3.ToString();
                }
                break;
        }
        RefreshMetierPoint();
    }
    public void RefreshMetierPoint()
    {
        switch (job)
        {
            case shop.Vetement:
                intLuxe = SousMetier1;
                intSport = SousMetier2;
                intQuotidiens = SousMetier3;
                break;

            case shop.Service:
                intAidePerso = SousMetier1;
                intCoachSport = SousMetier2;
                intProfParticulier = SousMetier3;
                break;

            case shop.Velo:
                intVTT = SousMetier1;
                intCourse = SousMetier2;
                intVille = SousMetier3;
                break;

            case shop.Aliment:
                intSurgele = SousMetier1;
                intBio = SousMetier2;
                intLivraison = SousMetier3;
                break;
        }
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

    public string GetUserName() { return UserName; }
    public string GetEntrepriseName() { return EntrepriseName; }
    public int GetMoney() { return Money; }
    public shop GetShop() { return job; }
    public place GetPlace() { return lieu; }

    public int GetLuxe() { return intLuxe; }
    public int GetSport() { return intSport; }
    public int GetQuotidiens() { return intQuotidiens; }

    public int GetAidePerso() { return intAidePerso; }
    public int GetCoachSport() { return intCoachSport; }
    public int GetProfParticulier() { return intProfParticulier; }

    public int GetBio() { return intBio; }
    public int GetLivraison() { return intLivraison; }
    public int GetSurgele() { return intSurgele; }

    public int GetVTT() { return intVTT; }
    public int GetCourses() { return intCourse; }
    public int GetVille() { return intVille; }

    public void RefreshData(SaveData saveData)
    {
        Named(saveData.UserName);
        Money = saveData.Money;
        lieu = saveData.Lieu;
        job = saveData.Shop;

        intSurgele = saveData.intSurgele;
        intLivraison = saveData.intLivraison;
        intBio = saveData.intBio;
        intCourse = saveData.intCourse;
        intVTT = saveData.intVTT;
        intVille = saveData.intVille;
        intAidePerso = saveData.intAidePerso;
        intProfParticulier = saveData.intProfParticulier;
        intCoachSport = saveData.intCoachSport;
        intLuxe = saveData.intLuxe;
        intSport = saveData.intSport;
        intQuotidiens = saveData.intQuotidiens;

        GameManager.LoadPlace(lieu);
        gestionnaireUI.RefreshData();
       
    }

    public void Load()
    {
        string savePath = Application.persistentDataPath + "/sauvegarde" + SaveData.onSave + ".json";

        if (File.Exists(savePath))
        {
            string jsonData = File.ReadAllText(savePath);
            SaveData saveData = new SaveData();
            JsonUtility.FromJsonOverwrite(jsonData, saveData);

            RefreshData(saveData);
            Debug.Log("Load : " + SaveData.onSave + " Entreprise on save" + savePath);
        }
        else
        {
            Debug.LogError("Le fichier de sauvegarde n'existe pas.");
        }
    }
}
