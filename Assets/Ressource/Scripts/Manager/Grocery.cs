using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grocery : MonoBehaviour
{
    public GameObject Notebook;

    private void Start()
    {
        Interact.interactEvent += OpenGrocery;
    }

    public void OpenGrocery()
    {
        if (!Notebook.activeSelf)
        {
            Debug.Log("Groceryyy");
        }
    }
}
