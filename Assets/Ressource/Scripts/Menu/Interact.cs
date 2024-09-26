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

    /*private Material[] original;
    private Material[] outline;
    private Material[] mats;*/

    public static Action<bool> canInteractEvent = null;
    public static Action<ID> interactEvent;

    private bool canInteract = false;

    public Outline outline;


    public enum ID
    {
        Bebot,
        Commercant, 
        Kiosque,
        Mairie
    }

    public ID id;

    private void Start()
    {
        ThirdPersonController.MyInteractEvent += Interaction;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            outline.outlineWidth = 2f;
            outline.UpdateMaterialProperties();
            canInteract = true;
            canInteractEvent?.Invoke(canInteract);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            outline.outlineWidth = 0;
            outline.UpdateMaterialProperties();
            canInteract = false;
            canInteractEvent?.Invoke(canInteract);
        }
    }

    private void Interaction()
    {
        if (canInteract)
        {
            interactEvent?.Invoke(id);
        }
    }
    private void OnDestroy()
    {
        ThirdPersonController.MyInteractEvent -= Interaction;
    }
}
