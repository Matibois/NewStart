using StarterAssets;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Entreprise;

public class GameManager : MonoBehaviour
{

    private string selectedScene;

    public static void LoadMainMenu()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadScene("Menu");
    }

    public static void LoadWhiteMontain()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadScene("WhiteMontain");
    }
    public static void LoadUrbanCity()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadScene("UrbanCity");
    }
    public static void LoadFenzyFarm()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadScene("FenzyFarm");
    }
    public static void LoadPalmCoconut()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadScene("PalmCoconut");
    }

    public static void LoadPlace(place lieu)
    {
        switch (lieu)
        {
            case place.PalmCoconut:
                LoadPalmCoconut();
                break;
            case place.FenzyFarm:
                LoadFenzyFarm();
                break;
            case place.UrbanCity:
                LoadUrbanCity();
                break;
            case place.WhiteMontain:
                LoadWhiteMontain();
                break;
        }
    }

    public void SelectWhiteMontain()
    {
        selectedScene = "WhiteMontain";
    }
    public void SelectUrbanCity()
    {
        selectedScene = "UrbanCity";
    }
    public void SelectFenzyFarm()
    {
        selectedScene = "FenzyFarm";
    }
    public void SelectPalmCoconut()
    {
        selectedScene = "PalmCoconut";
    }

}
