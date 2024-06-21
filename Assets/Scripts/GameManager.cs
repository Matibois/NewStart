using StarterAssets;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Entreprise;

public class GameManager : MonoBehaviour
{
    public static void LoadMainMenu()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadScene("Menu");
    }

    public static void LoadFileSelection()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadScene("FileSelection");
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
}
