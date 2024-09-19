using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSize : MonoBehaviour
{
    public GameObject small;
    public GameObject medium;
    public GameObject large;


    public int BoxSizeChoice(string text)
    {
        if (text.Length >= 210) //Large Box 210
        {
            DisplayBox(3);
            return 3;
        }
        if (text.Length > 93) //Medium Box
        {
            DisplayBox(2);
            return 2;
        }
        DisplayBox(1);
        return 1;
    }

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
