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
    [SerializeField] GameObject ValidateJobBtn;
    [SerializeField] GameObject AlimentDB;
    [SerializeField] GameObject VeloDB;
    [SerializeField] GameObject ServiceDB;
    [SerializeField] GameObject VetementDB;


    [SerializeField] public string UserName;
    [SerializeField] public shop job;
    [SerializeField] public int Money;
    [SerializeField] public int TypeChoice;
    [SerializeField] public place lieu;

    [SerializeField] public AlimentType alimentType;
    [SerializeField] public VeloType veloType;
    [SerializeField] public ServiceType serviceType;
    [SerializeField] public VetementType vetementType;
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
    public enum AlimentType
    {
        Surgele,
        Bio,
        Livraison,
    }
    public enum VeloType
    {
        Course,
        VTT,
        Ville,
    }
    public enum ServiceType
    {
        CoachSport,
        AidePerso,
        ProfParticulier,
    }
    public enum VetementType
    {
        Luxe,
        Sport,
        Quotidiens,
    }

    public SaveData saveData;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

    }

    public void Named()
    {
        UserName = NameEntry.text;
        NameText.text = UserName;
    }

    public void JobChoice()
    {
        switch (JobDB.value)
        {
            case 1:
                job = shop.Aliment;
                JobText.text = "Magasin alimentaire";
                ValidateJobBtn.SetActive(true);
                AlimentDB.SetActive(true);
                VeloDB.SetActive(false);
                ServiceDB.SetActive(false);
                VetementDB.SetActive(false);
                jobtype = AlimentDB.GetComponent<TMP_Dropdown>();
                break;

            case 2:
                job = shop.Velo;
                JobText.text = "Magasin de Velo";
                ValidateJobBtn.SetActive(true);
                VeloDB.SetActive(true);
                ServiceDB.SetActive(false);
                VetementDB.SetActive(false);
                AlimentDB.SetActive(false);
                jobtype = VeloDB.GetComponent<TMP_Dropdown>();
                break;

            case 3:
                job = shop.Service;
                JobText.text = "Service Personnelle";
                ValidateJobBtn.SetActive(true);
                ServiceDB.SetActive(true);
                VeloDB.SetActive(false);
                AlimentDB.SetActive(false);
                VetementDB.SetActive(false);

                jobtype = ServiceDB.GetComponent<TMP_Dropdown>();
                break;

            case 4:
                job = shop.Vetement;
                JobText.text = "Magasin de vetement";
                ValidateJobBtn.SetActive(true);
                VetementDB.SetActive(true);
                VeloDB.SetActive(false);
                ServiceDB.SetActive(false);
                AlimentDB.SetActive(false);
                jobtype = VetementDB.GetComponent<TMP_Dropdown>();
                break;

            case 0:

                ValidateJobBtn.SetActive(false);
                VetementDB.SetActive(false);
                VeloDB.SetActive(false);
                ServiceDB.SetActive(false);
                AlimentDB.SetActive(false);
                JobText.text = " ";
                break;
        }
    }
    public void PosChoice()
    {
        switch (job)
        {
            case shop.Aliment:
                switch (jobtype.value)
                {
                    case 0:
                        alimentType = AlimentType.Surgele;
                        PosText.text = "Surgelé";
                        break;

                    case 1:
                        alimentType = AlimentType.Bio;
                        PosText.text = "Bio";
                        break;

                    case 2:
                        alimentType = AlimentType.Livraison;
                        PosText.text = "Livraison";
                        break;
                }
                break;

            case shop.Velo:
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
                        veloType = VeloType.Ville;
                        PosText.text = "Ville";
                        break;
                }
                break;

            case shop.Service:
                switch (jobtype.value)
                {
                    case 0:
                        serviceType = ServiceType.CoachSport;
                        PosText.text = "Coach sportif";
                        break;

                    case 1:
                        serviceType = ServiceType.AidePerso;
                        PosText.text = "Aide à la personne";
                        break;

                    case 2:
                        serviceType = ServiceType.ProfParticulier;
                        PosText.text = "Prof particulier";
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
                        vetementType = VetementType.Quotidiens;
                        PosText.text = "Quotidiens";
                        break;
                }
                break;
        }
    }

    public void RefreshPlace()
    {
        switch (lieu)
        {
            case place.WhiteMontain:
                lieu = place.WhiteMontain;
                PlaceText.text = "White Montain";
                break;

            case place.PalmCoconut:
                lieu = place.PalmCoconut;
                PlaceText.text = "Palm Coconut";
                break;

            case place.UrbanCity:
                lieu = place.UrbanCity;
                PlaceText.text = "Urban City";
                break;

            case place.FenzyFarm:
                lieu = place.FenzyFarm;
                PlaceText.text = "Fenzy Farm";
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
    public AlimentType GetAlimentType() { return alimentType; }
    public VeloType GetVeloType() { return veloType; }
    public ServiceType GetServiceType() { return serviceType; }
    public VetementType GetVetementType() { return vetementType; }

    public int GetLuxe() {return intLuxe;}
    public int GetSport() {return intSport;}
    public int GetQuotidiens() {return intQuotidiens;}

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
        UserName = saveData.UserName;
        Money = saveData.Money;
        lieu = saveData.Lieu;
        job = saveData.Shop;
        alimentType = saveData.AlimentType;
        veloType = saveData.VeloType;
        serviceType = saveData.ServiceType;
        vetementType = saveData.VetementType;

        NameText.text = UserName;
        PlaceText.text = lieu.ToString();

        switch (job)
        {
            case shop.Aliment:
                JobText.text = job.ToString();
                PosText.text = alimentType.ToString();
                break;
            case shop.Velo:
                JobText.text = job.ToString();
                PosText.text = veloType.ToString();
                break;
            case shop.Service:
                JobText.text = job.ToString();
                PosText.text = serviceType.ToString();
                break;
            case shop.Vetement:
                JobText.text = job.ToString();
                PosText.text = vetementType.ToString();
                break;
        }
        GameManager.LoadPlace(lieu);

    }

    public void Load()
    {
        string savePath = Application.persistentDataPath + "/sauvegarde" + SaveData.onSave + ".json";

        if (File.Exists(savePath))
        {
            string jsonData = File.ReadAllText(savePath);

            SaveData saveData = new SaveData();
            JsonUtility.FromJsonOverwrite(jsonData, saveData);

            // Mettez à jour les valeurs de la classe Entreprise avec les données désérialisées


            RefreshData(saveData);
            Debug.Log("Load : " + SaveData.onSave + " Entreprise on save" + savePath);
        }
        else
        {
            Debug.LogError("Le fichier de sauvegarde n'existe pas.");
        }
    }

}
