using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MenuPause : MonoBehaviour
{

    //private GameObject MenuUI;
    private bool paused = true;

    void Start()
    {
        Time.timeScale = 0;
        //MenuUI = GetComponent<GameObject>();
    }

    public void pause()
    {
        Time.timeScale = paused ? 1 : 0;
        paused = !paused;
    }

    public void Stop()
    {
        Time.timeScale = 0;
    }

    public void Play()
    {
        Time.timeScale = 1;
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
