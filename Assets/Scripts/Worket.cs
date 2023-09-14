using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Entreprise;

[System.Serializable]
public class Worket : MonoBehaviour
{
    [SerializeField] public Marche WhiteMontain;
    [SerializeField] public Marche PalmCoconut;
    [SerializeField] public Marche FenzyFarm;
    [SerializeField] public Marche UrbanCity;
   
    public Worket() {}

    
    private void Awake() => DontDestroyOnLoad(this.gameObject);
    void Start()
    {
        WhiteMontain = new Marche();
        PalmCoconut = new Marche();
        UrbanCity = new Marche();
        FenzyFarm = new Marche();
    }

    public Worket initiateWorket(Worket worket)
    {
        worket.WhiteMontain = WhiteMontain;
        worket.PalmCoconut = PalmCoconut;
        worket.FenzyFarm = FenzyFarm;
        worket.UrbanCity = UrbanCity;
        return worket;
    }

    public void Load()
    {
        string savePath = Application.persistentDataPath + "/sauvegarde" + SaveData.onSave + ".json";

        if (File.Exists(savePath))
        {
            string jsonData = File.ReadAllText(savePath);
            SaveData saveData = new SaveData();
            JsonUtility.FromJsonOverwrite(jsonData, saveData);

            Worket worket = saveData.worket;
            WhiteMontain = saveData.WhiteMontain;
            PalmCoconut = saveData.PalmCoconut;
            UrbanCity = saveData.UrbanCity;
            FenzyFarm = saveData.FenzyFarm;

            Debug.Log("Load" + SaveData.onSave +" From Worket Path : " + savePath);
        }
        else Debug.LogError("Le fichier de sauvegarde n'existe pas."); 
    }

}