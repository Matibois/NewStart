using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using StarterAssets;
using System;

public class Interact : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject player;
    [SerializeField] GameObject parentObject;

    Material[] original;
    Material[] outline;
    Material[] mats;

    public static Action<bool> canInteractEvent = null;

    Ray ray;
    RaycastHit hit;
    private bool canInteract = false;

    private void OnDestroy()
    {
        ThirdPersonController.MyInteractEvent -= Interaction;
    }

    private void Start()
    {
        Material[] mats = parentObject.GetComponent<Renderer>().materials;
        outline = mats;
        original = new Material[] { outline[0], outline[0] };
        parentObject.GetComponent<Renderer>().materials = original;
        print("oui");
        ThirdPersonController.MyInteractEvent += Interaction;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            parentObject.GetComponent<Renderer>().materials = outline;
            canInteract = true;
            print("collide");
            canInteractEvent?.Invoke(canInteract);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            parentObject.GetComponent<Renderer>().materials = original;
            canInteract = false;
            print("NO collide");
            canInteractEvent?.Invoke(canInteract);
        }
    }

    private void Interaction()
    {
        if (canInteract)
        {

        }
    }
}
