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

    public void OpenGrocery(Interact.ID id )
    {
        if (!Notebook.activeSelf && id == Interact.ID.Commercant)
        {
            Debug.Log("Groceryyy");
        }
    }
}
