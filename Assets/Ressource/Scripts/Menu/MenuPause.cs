using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MenuPause : MonoBehaviour
{
    

    //private GameObject MenuUI;
    private bool paused = false;

    void Start()
    {
        Time.timeScale = 1;
        //MenuUI = GetComponent<GameObject>();
    }

    public void pause()
    {
        Time.timeScale = paused ? 1 : 0;
        paused = !paused;
    }

    static public void Stop()
    {
        Time.timeScale = 0;
    }

    static public void Play()
    {
        Time.timeScale = 1;
    }

}
