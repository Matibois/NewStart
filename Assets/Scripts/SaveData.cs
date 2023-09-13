using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using static Entreprise;

[System.Serializable]
public class SaveData : MonoBehaviour
{
    public GameObject profil;
    public GameObject marche;

    private Entreprise entreprise;
    public string UserName;
    public int Money;
    public place Lieu;
    public shop Shop;
    public AlimentType AlimentType;
    public VeloType VeloType;
    public ServiceType ServiceType;
    public VetementType VetementType;

    [SerializeField] public Worket worket;
    [SerializeField] public Marche WhiteMontain;
    [SerializeField] public Marche PalmCoconut;
    [SerializeField] public Marche FenzyFarm;
    [SerializeField] public Marche UrbanCity;

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

    public static int onSave = 1;
    public SaveData() { }

    public void InitializeSaveData()
    {
        entreprise = FindObjectOfType<Entreprise>();
        worket = FindObjectOfType<Worket>();
        worket = worket.initiateWorket(worket);

        WhiteMontain = worket.WhiteMontain;
        PalmCoconut = worket.PalmCoconut;
        FenzyFarm = worket.FenzyFarm;
        UrbanCity = worket.UrbanCity;

        if (worket == null) Debug.LogError("worket null from savedata");
        Debug.Log(" initiate save" + WhiteMontain.Habitants);

        UserName = entreprise.GetUserName();
        Money = entreprise.GetMoney();
        Lieu = entreprise.GetPlace();
        Shop = entreprise.GetShop();

        AlimentType = entreprise.GetAlimentType();
        VeloType = entreprise.GetVeloType();
        ServiceType = entreprise.GetServiceType();
        VetementType = entreprise.GetVetementType();

        intSurgele = entreprise.GetSurgele();
        intLivraison = entreprise.GetLivraison();
        intBio = entreprise.GetBio();
        intCourse = entreprise.GetCourses();
        intVTT = entreprise.GetVTT();
        intVille = entreprise.GetVille();
        intAidePerso = entreprise.GetAidePerso();
        intProfParticulier = entreprise.GetProfParticulier();
        intCoachSport = entreprise.GetCoachSport();
        intLuxe = entreprise.GetLuxe();
        intSport = entreprise.GetSport();
        intQuotidiens = entreprise.GetQuotidiens();
    }

    public void Save()
    {
        SaveData playerData = new SaveData();
        playerData.InitializeSaveData();

        string jsonData = JsonUtility.ToJson(playerData);

        string filePath = Application.persistentDataPath + "/sauvegarde" + onSave + ".json";
        System.IO.File.WriteAllText(filePath, jsonData);

        Debug.Log("JSON data saved to: " + filePath);

    }

    public void ChangeSave(int save)
    {
        onSave = save;
    }




}
