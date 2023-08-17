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
    public RestauType RestauType;
    public VeloType VeloType;
    public CoachType CoachType;
    public VetementType VetementType;

    [SerializeField] public Worket worket;
    [SerializeField] public Marche WhiteMontain;
    [SerializeField] public Marche PalmCoconut;
    [SerializeField] public Marche FenzyFarm;
    [SerializeField] public Marche UrbanCity;

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

        RestauType = entreprise.GetRestauType();
        VeloType = entreprise.GetVeloType();
        CoachType = entreprise.GetCoachType();
        VetementType = entreprise.GetVetementType();

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

    public void Save1()
    {
        SaveData playerData = new SaveData();
        playerData.InitializeSaveData();

        string jsonData = JsonUtility.ToJson(playerData);

        string filePath = Application.persistentDataPath + "/sauvegarde1.json";
        System.IO.File.WriteAllText(filePath, jsonData);

        Debug.Log("JSON data saved to: " + filePath);

    }
    public void Save2()
    {
        SaveData playerData = new SaveData();
        playerData.InitializeSaveData();

        string jsonData = JsonUtility.ToJson(playerData);

        string filePath = Application.persistentDataPath + "/sauvegarde2.json";
        System.IO.File.WriteAllText(filePath, jsonData);

        Debug.Log("JSON data saved to: " + filePath);

    }
    public void Save3()
    {
        SaveData playerData = new SaveData();
        playerData.InitializeSaveData();

        string jsonData = JsonUtility.ToJson(playerData);

        string filePath = Application.persistentDataPath + "/sauvegarde3.json";
        System.IO.File.WriteAllText(filePath, jsonData);

        Debug.Log("JSON data saved to: " + filePath);

    }
    public void Save4()
    {
        SaveData playerData = new SaveData();
        playerData.InitializeSaveData();

        string jsonData = JsonUtility.ToJson(playerData);

        string filePath = Application.persistentDataPath + "/sauvegarde4.json";
        System.IO.File.WriteAllText(filePath, jsonData);

        Debug.Log("JSON data saved to: " + filePath);

    }

   
}
