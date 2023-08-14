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

    void Start()
    {
        WhiteMontain = new Marche();
        PalmCoconut = new Marche();
        FenzyFarm = new Marche();
        UrbanCity = new Marche();
        Debug.Log( WhiteMontain.Habitants + " wm habitant from Worket start");
    }

    public Worket initiateWorket(Worket worket)
    {
        worket.WhiteMontain = WhiteMontain;
        worket.PalmCoconut = PalmCoconut;
        worket.FenzyFarm = FenzyFarm;
        worket.UrbanCity = UrbanCity;
        return worket;
    }

    public void Load1()
    {
        string savePath = Application.persistentDataPath + "/sauvegarde1.json";

        if (File.Exists(savePath))
        {
            string jsonData = File.ReadAllText(savePath);
            SaveData saveData = new SaveData();
            JsonUtility.FromJsonOverwrite(jsonData, saveData);

            Worket worket = saveData.worket;

            Debug.Log("Load 1 From Worket Path : " + savePath);
        }
        else
        {
            Debug.LogError("Le fichier de sauvegarde n'existe pas.");
        }
    }
 

}