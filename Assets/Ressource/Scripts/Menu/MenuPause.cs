using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class MenuPause : MonoBehaviour
{

    static public Action<bool> canMoveEvent;
    private bool canMove;

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

    public void Stop()
    {
        //Time.timeScale = 0;
    }

    public void Play()
    {
        Time.timeScale = 1;
    }

    private void StopMovement()
    {
        canMove = false;
        canMoveEvent?.Invoke(canMove);
    }

    private void PlayMovement()
    {
        canMove = true;
        canMoveEvent?.Invoke(canMove);
    }

}
