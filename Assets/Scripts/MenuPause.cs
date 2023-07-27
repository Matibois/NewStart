using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class MenuPause : MonoBehaviour
{

    //private GameObject MenuUI;
    private bool paused = true;

    void Start()
    {
        Time.timeScale = 0;
        //MenuUI = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void menu()
    {

    }

    public void pause()
    {
        Time.timeScale = paused ? 1 : 0;
        paused = !paused;
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }

}
