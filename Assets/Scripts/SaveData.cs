using System.IO;
using UnityEngine;
using static Entreprise;

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

    public Worket worket;
    public Marche WhiteMontain;
    public Marche PalmCoconut;
    public Marche FenzyFarm;
    public Marche UrbanCity;

    public SaveData() { }

    private void Start()
    {
        entreprise = FindObjectOfType<Entreprise>();
        worket = FindObjectOfType<Worket>();

        if (entreprise != null)
        {
            // Appeler la méthode pour récupérer les informations de l'entreprise
            InitializeSaveData();
        }
        else
        {
            Debug.LogError("Erreur : Objet Entreprise non trouvé dans la scène.");
        }
    }

    public void InitializeSaveData()
    {
        entreprise = FindObjectOfType<Entreprise>();
        worket = FindObjectOfType<Worket>();

        UserName = entreprise.GetUserName();
        Money = entreprise.GetMoney();
        Lieu = entreprise.GetPlace();
        Shop = entreprise.GetShop();
        RestauType = entreprise.GetRestauType();
        VeloType = entreprise.GetVeloType();
        CoachType = entreprise.GetCoachType();
        VetementType = entreprise.GetVetementType();
        Debug.Log("save data n: " + UserName);
        Debug.Log("save data m: " + Money);
        Debug.Log("save data l: " + Lieu);
        Debug.Log("save data s: " + Shop);

        WhiteMontain = worket.GetWhiteMontain();
        PalmCoconut = worket.GetPalmCoconut();
        FenzyFarm = worket.GetFenzyFarm();
        UrbanCity = worket.GetUrbanCity();

        //Debug.Log("save data wm h: " + WhiteMontain.Habitants);
    }

    public SaveData saveObject()
    {
        SaveData saveData = new SaveData();
        return saveData;
    }

    public void Save()
    {
        SaveData playerData = saveObject();
        
         
        playerData.InitializeSaveData();

        // Sérialiser l'objet en JSON
        string jsonData = JsonUtility.ToJson(playerData);

        // Sauvegarder le JSON dans un fichier
        string filePath = Application.persistentDataPath + "/sauvegarde.json";
        System.IO.File.WriteAllText(filePath, jsonData);

        Debug.Log("JSON data saved to: " + filePath);
        
    }

    
    

    /*public void Load()
    {
        string savePath = Application.persistentDataPath + "/data.json";

        // Vérifiez si le fichier existe avant de le charger
        if (File.Exists(savePath))
        {
            // Lisez le contenu du fichier JSON en tant que chaîne
            string jsonData = File.ReadAllText(savePath);

            // Désérialisez le contenu JSON en un objet SaveDataObject
            SaveData saveDataObject = JsonUtility.FromJson<SaveData>(jsonData);

            // Mettez à jour les valeurs de la classe SaveData avec les données désérialisées
            UserName = saveDataObject.UserName;
            Money = saveDataObject.Money;
            Lieu = saveDataObject.Lieu;
            Shop = saveDataObject.Shop;
            RestauType = saveDataObject.RestauType;
            VeloType = saveDataObject.VeloType;
            CoachType = saveDataObject.CoachType;
            VetementType = saveDataObject.VetementType;

            WhiteMontain = saveDataObject.WhiteMontain;
            PalmCoconut = saveDataObject.PalmCoconut;
            FenzyFarm = saveDataObject.FenzyFarm;
            UrbanCity = saveDataObject.UrbanCity;

            // Mettez à jour les autres membres de SaveData si nécessaire
            Debug.Log("save data n: " + UserName);
            Debug.Log("save data m: " + Money);
            Debug.Log("save data l: " + Lieu);
            Debug.Log("save data s: " + Shop);

            Debug.Log("Chargement réussi depuis le fichier JSON.");
        }
        else
        {
            Debug.LogError("Le fichier de sauvegarde n'existe pas.");
        }
    }*/

    /*public SaveData Load()
    {
        string savePath = Application.persistentDataPath + "/sauvegarde.json";

        // Vérifiez si le fichier existe avant de le charger
        if (File.Exists(savePath))
        {
            // Lisez le contenu du fichier JSON en tant que chaîne
            string jsonData = File.ReadAllText(savePath);

            // Désérialisez le contenu JSON en un nouvel objet SaveData
            SaveData saveData = JsonUtility.FromJson<SaveData>(jsonData);

            Debug.Log("Chargement réussi depuis le fichier JSON.");
            return saveData;
        }
        else
        {
            Debug.LogError("Le fichier de sauvegarde n'existe pas.");
            return null;
        }
    }*/

    

}
