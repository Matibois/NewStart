using System.IO;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static Entreprise;
using UnityEngine.Rendering.Universal;
using System;

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

    [SerializeField] TMP_Text SousMetier1Name;
    [SerializeField] TMP_Text SousMetier2Name;
    [SerializeField] TMP_Text SousMetier3Name;

    [SerializeField] TMP_Text SousMetier1Points;
    [SerializeField] TMP_Text SousMetier2Points;
    [SerializeField] TMP_Text SousMetier3Points;

    private int SousMetier1Price;
    private int SousMetier2Price;
    private int SousMetier3Price;

    [SerializeField] Slider SousMetier1Slider;
    [SerializeField] Slider SousMetier2Slider;
    [SerializeField] Slider SousMetier3Slider;

    [SerializeField] TMP_Text pubPointText;
    [SerializeField] TMP_Text newsLetterPointText;
    [SerializeField] TMP_Text boiteAuLettrePointText;

    [SerializeField] TMP_Text fakebookPointText;
    [SerializeField] TMP_Text yourTubePointText;
    [SerializeField] TMP_Text amstramgramPointText;

    [SerializeField] TMP_Text magTelePointText;
    [SerializeField] TMP_Text libertePointText;
    [SerializeField] TMP_Text svjPointText;     

    public TMP_Dropdown JobDB;
    [SerializeField] GameObject ValidateJobBtn;

    [SerializeField] private GestionnaireUI gestionnaireUI;

     public string UserName; //Il était en private, je l'ai passé en public pour le récup ailleurs. Si j'ai merdé spam moi?.
     private string EntrepriseName;
     private shop job;
     private int Money;
     private int TypeChoice;
     private place lieu;

    public int intSurgele;
    public int intLivraison;
    public int intBio;
    
    public int intCourse;
    public int intVTT;
    public int intVille;
    
    public int intAidePerso;
    public int intProfParticulier;
    public int intCoachSport;
    
    public int intLuxe;
    public int intSport;
    public int intQuotidiens;
    
    private int sousMetierPoint = 4;
    private int SousMetier1;
    private int SousMetier2;
    private int SousMetier3;

    private int comPoint = 5;
    private int intTransport;
    private int intNewsLetters;
    private int intBoiteAuLettre;
    
    private int intFakebook;
    private int intYourTube;
    private int intAmstramgram;
    
    private int intMagTele;
    private int intLiberte;
    private int intSVJ;

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

    public void Named(string name)
    {
        if (name != null && name != string.Empty)
        {
            UserName = name;
            NameText.text = UserName;
        }
        else
        {
            UserName = NameEntry.text;
            NameText.text = UserName;
        }
        Debug.Log("Name : " + UserName);
    }
    public void EntrepriseNamed(string name)
    {
        if (name != null && name != string.Empty)
        {
            EntrepriseName = name;
            EntrepriseNameText.text = EntrepriseName;
        }
        else
        {
            UserName = EntrepriseNameEntry.text;
            EntrepriseNameText.text = UserName;
        }
        Debug.Log("Entreprise name : " + name);
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
                SousMetier1Name.text = "Surgele";
                SousMetier2 = intBio;
                SousMetier2Name.text = "Bio";
                SousMetier3 = intLivraison;
                SousMetier3Name.text = "Livraison";
                break;

            case 2:
                job = shop.Velo;
                JobText.text = "Magasin de Velo";
                ValidateJobBtn.SetActive(true);
                SousMetier1 = intVTT;
                SousMetier1Name.text = "VTT";
                SousMetier2 = intCourse;
                SousMetier2Name.text = "Course";
                SousMetier3 = intVille;
                SousMetier3Name.text = "Ville";
                break;

            case 3:
                job = shop.Service;
                JobText.text = "Service Personnelle";
                ValidateJobBtn.SetActive(true);
                SousMetier1 = intAidePerso;
                SousMetier1Name.text = "Aide Personnelle";
                SousMetier2 = intCoachSport;
                SousMetier2Name.text = "Coach Sportif";
                SousMetier3 = intProfParticulier;
                SousMetier3Name.text = "Professeur Particulier";
                break;

            case 4:
                job = shop.Vetement;
                JobText.text = "Magasin de vetement";
                ValidateJobBtn.SetActive(true);
                SousMetier1 = intLuxe;
                SousMetier1Name.text = "Luxe";
                SousMetier2 = intSport;
                SousMetier2Name.text = "Sport";
                SousMetier3 = intQuotidiens;
                SousMetier3Name.text = "Quotidiens";
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
                    SousMetier1++;
                    sousMetierPoint--;
                    SousMetier1Points.text = SousMetier1.ToString();
                    break;

                case 2:
                    SousMetier2++;
                    sousMetierPoint--;
                    SousMetier2Points.text = SousMetier2.ToString();
                    break;

                case 3:
                    SousMetier3++;
                    sousMetierPoint--;
                    SousMetier3Points.text = SousMetier3.ToString();
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
                    SousMetier1Points.text = SousMetier1.ToString();
                }
                break;

            case 2:
                if (SousMetier2 > 0)
                {
                    SousMetier2--;
                    sousMetierPoint++;
                    SousMetier2Points.text = SousMetier2.ToString();
                }
                break;

            case 3:
                if (SousMetier3 > 0)
                {
                    SousMetier3--;
                    sousMetierPoint++;
                    SousMetier3Points.text = SousMetier3.ToString();
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

    public void ComAddPoint(int com)
    {
        if (comPoint > 0)
        {
            switch (com)
            {
                case 1:
                    intTransport++;
                    comPoint--;
                    break;

                case 2:
                    intNewsLetters++;
                    comPoint--;
                    break;

                case 3:
                    intBoiteAuLettre++;
                    comPoint--;
                    break;

                case 4:
                    intFakebook++;
                    comPoint--;
                    break;

                case 5:
                    intYourTube++;
                    comPoint--;
                    break;

                case 6:
                    intAmstramgram++;
                    comPoint--;
                    break;

                case 7:
                    intMagTele++;
                    comPoint--;
                    break;

                case 8:
                    intLiberte++;
                    comPoint--;
                    break;

                case 9:
                    intSVJ++;
                    comPoint--;
                    break;
            }
        }
    }
    public void ComRemovePoint(int com)
    {
        switch (com)
        {
            case 1:
                if (intTransport > 0)
                {
                    intTransport--;
                    comPoint++;
                }
                break;

            case 2:
                if (intNewsLetters > 0)
                {
                    intNewsLetters--;
                    comPoint++;
                }
                break;

            case 3:
                if (intBoiteAuLettre > 0)
                {
                    intBoiteAuLettre--;
                    comPoint++;
                }
                break;

            case 4:
                if (intFakebook > 0)
                {
                    intFakebook--;
                    comPoint++;
                }
                break;

            case 5:
                if (intYourTube > 0)
                {
                    intYourTube--;
                    comPoint++;
                }
                break;

            case 6:
                if (intAmstramgram > 0)
                {
                    intAmstramgram--;
                    comPoint++;
                }
                break;

            case 7:
                if (intMagTele > 0)
                {
                    intMagTele--;
                    comPoint++;
                }
                break;

            case 8:
                if (intLiberte > 0)
                {
                    intLiberte--;
                    comPoint++;
                }
                break;

            case 9:
                if (intSVJ > 0)
                {
                    intSVJ--;
                    comPoint++;
                }
                break;
        }
    }

    public void setPrice(int sousMetier)
    {
        SousMetier1Price = (int)SousMetier1Slider.value;
        SousMetier2Price = (int)SousMetier2Slider.value;
        SousMetier3Price = (int)SousMetier3Slider.value;
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

    #region Getters
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

    public int[] GetPrice()
    {
        return new int[] { SousMetier1Price, SousMetier2Price, SousMetier3Price };
    }

    public int GetTransport() { return intTransport; }
    public int GetNewsLetters() { return intNewsLetters; }
    public int GetBoiteAuLettre() { return intBoiteAuLettre; }

    public int GetFakebook() { return intFakebook; }
    public int GetYourTube() { return intYourTube; }
    public int GetAmstramgram() { return intAmstramgram; }

    public int GetMagTele() { return intMagTele; }
    public int GetLiberte() { return intLiberte; }
    public int GetSVJ() { return intSVJ; }


    #endregion

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
