using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject player;
    [SerializeField] GameObject parentObject;

    Material[] original;
    Material[] outline;
    Material[] mats;

    private void Start()
    {
        Material[] mats = parentObject.GetComponent<Renderer>().materials;
        outline = mats;
        original = new Material[] { outline[0], outline[0] };
        parentObject.GetComponent<Renderer>().materials = original;
        print("oui");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mats = outline;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mats = original;
        }
    }

}
