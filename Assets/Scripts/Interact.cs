using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    [SerializeField] GameObject menu;

    private void OnTriggerEnter(Collider other)
    {
        menu.SetActive(true);
    }

    
}
