using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSize : MonoBehaviour
{
    public GameObject small;
    public GameObject medium;
    public GameObject large;


    public void DisplayBox(int size) 
    {
        switch (size)
        {
            case 1:
                small.gameObject.SetActive(true);
                medium.gameObject.SetActive(false);
                large.gameObject.SetActive(false);
                break;

            case 2:
                small.gameObject.SetActive(false);
                medium.gameObject.SetActive(true);
                large.gameObject.SetActive(false);
                break;

            case 3:
                small.gameObject.SetActive(false);
                medium.gameObject.SetActive(false);
                large.gameObject.SetActive(true);
                break;
        }
    }
}
