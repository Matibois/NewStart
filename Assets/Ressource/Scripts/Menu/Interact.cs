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
    [SerializeField] Renderer parentObject;

    private Material[] original;
    private Material[] outline;
    private Material[] mats;

    public static Action<bool> canInteractEvent = null;
    public static Action interactEvent;

    private bool canInteract = false;


    private void Start()
    {
        Material[] mats = parentObject.materials;
        outline = mats;
        original = new Material[] { outline[0], outline[0] };
        parentObject.materials = original;
        ThirdPersonController.MyInteractEvent += Interaction;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            parentObject.materials = outline;
            canInteract = true;
            canInteractEvent?.Invoke(canInteract);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            parentObject.materials = original;
            canInteract = false;
            canInteractEvent?.Invoke(canInteract);
        }
    }

    private void Interaction()
    {
        if (canInteract)
        {
            parentObject.GetComponent<Renderer>().materials = original;
            interactEvent?.Invoke();
        }
    }
    private void OnDestroy()
    {
        ThirdPersonController.MyInteractEvent -= Interaction;
    }
}
