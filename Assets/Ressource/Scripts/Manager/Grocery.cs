using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grocery : MonoBehaviour
{
    public GameObject Notebook;
    public GameObject VendorSprite;

    private bool firstTime;
    private bool isOpened;

    private void Start()
    {
        isOpened = false;

        Interact.interactEvent += OpenGrocery;
    }

    public void OpenGrocery(Interact.ID id )
    {
        if (!Notebook.activeSelf && id == Interact.ID.Commercant)
        {
            isOpened = !isOpened;
            VendorSprite.SetActive(isOpened);
        }
    }

    private void OnDestroy()
    {
        Interact.interactEvent -= OpenGrocery;
    }
}
