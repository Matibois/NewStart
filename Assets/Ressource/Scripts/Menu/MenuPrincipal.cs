using System.IO;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;
using static Entreprise;

public class MenuPrincipal : MonoBehaviour
{
    TMP_Text[] LoadSave;
    TMP_Text[] LoadSaveData;
    TMP_Text[] NewSave;
    TMP_Text[] NewSaveData;

    public TMP_Text LoadSave1;
    public TMP_Text LoadSave2;
    public TMP_Text LoadSave3;
    public TMP_Text LoadSave4;

    public TMP_Text LoadSave1Data;
    public TMP_Text LoadSave2Data;
    public TMP_Text LoadSave3Data;
    public TMP_Text LoadSave4Data;

    public TMP_Text NewSave1;
    public TMP_Text NewSave2;
    public TMP_Text NewSave3;
    public TMP_Text NewSave4;

    public TMP_Text NewSave1Data;
    public TMP_Text NewSave2Data;
    public TMP_Text NewSave3Data;
    public TMP_Text NewSave4Data;



    private void Start()
    {
        LoadSave = new TMP_Text[] { LoadSave1, LoadSave2, LoadSave3, LoadSave4 };
        LoadSaveData = new TMP_Text[] { LoadSave1Data, LoadSave2Data, LoadSave3Data, LoadSave4Data };
        NewSave = new TMP_Text[] { NewSave1, NewSave2, NewSave3, NewSave4 };
        NewSaveData = new TMP_Text[] { NewSave1Data, NewSave2Data, NewSave3Data, NewSave4Data };

    }

    public void DisplaySave(bool newsave)
    {
        Start();
        TMP_Text[] save;
        TMP_Text[] saveData;

        if (newsave)
        {
            save = NewSave;
            saveData = NewSaveData;
            Debug.Log("newsave");
        }
        else
        {
            save = LoadSave;
            saveData = LoadSaveData;
            Debug.Log("loadsave");
        }

        
        for (int i = 1; i <= 4; i++)
        {
            SaveData data = LoadData(i);
            
            if (!IsSaveEmpty(i)) DisplayData(data, save, saveData, i);
            else save[i - 1].text = "Fichier Vide"; 
        }
    }

    private void DisplayData(SaveData data, TMP_Text[] save, TMP_Text[] saveData, int n)
    {
        Debug.Log("display");
        save[n - 1].text = data.UserName;
        saveData[n - 1].text = data.Shop + " \n" + data.Lieu;
        Debug.Log("End Display");
    }

    private SaveData LoadData(int n)
    {
        string savePath = Application.persistentDataPath + "/sauvegarde" + n + ".json";

        if (File.Exists(savePath))
        {
            string jsonData = File.ReadAllText(savePath);

            SaveData saveData = new SaveData();
            JsonUtility.FromJsonOverwrite(jsonData, saveData);

            Debug.Log("Load" + n + " From menu P : " + savePath);
            return saveData;
        }
        else
        {
            Debug.LogError("Le fichier de sauvegarde n'existe pas.");
            return null;
        }
    }

    public bool IsSaveEmpty(int save)
    {
        string savePath = Application.persistentDataPath + "/sauvegarde" + save + ".json";

        if (File.Exists(savePath)) return false;
        else return true;
    }

}
