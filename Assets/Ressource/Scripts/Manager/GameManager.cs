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

    public static void LoadPlace(Place lieu)
    {
        switch (lieu)
        {
            case Place.PalmCoconut:
                LoadPalmCoconut();
                break;
            case Place.FenzyFarm:
                LoadFenzyFarm();
                break;
            case Place.UrbanCity:
                LoadUrbanCity();
                break;
            case Place.WhiteMontain:
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

    public void Quit()
    {
        // save the Game ?
        LoadMainMenu();
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();

#endif
    }

    public void OnApplicationQuit()
    {
        //save the Game ?
    }

}
