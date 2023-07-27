using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    SaveData playerData;


    void Start()
    {
        playerData = new SaveData();
        /* SaveData playerData = new SaveData();

         // Sérialiser l'objet en JSON
         string jsonData = JsonUtility.ToJson(playerData);

         // Sauvegarder le JSON dans un fichier
         string filePath = Application.persistentDataPath + "/data.json";
         System.IO.File.WriteAllText(filePath, jsonData);

         Debug.Log("JSON data saved to: " + filePath);*/

    }

    public void Save()
    {
       

        /*Debug.Log(playerData.name);

        // Sérialiser l'objet en JSON
        string jsonData = JsonUtility.ToJson(playerData);

        // Sauvegarder le JSON dans un fichier
        string filePath = Application.persistentDataPath + "/data.json";
        System.IO.File.WriteAllText(filePath, jsonData);

        Debug.Log("JSON data saved to: " + filePath);*/
    }
    
}
