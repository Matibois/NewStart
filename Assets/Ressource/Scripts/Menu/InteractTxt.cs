using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractTxt : MonoBehaviour
{
    [SerializeField] GameObject interactText;

    public Dialogue D;

    Quaternion angle;

    void Start()
    {
        angle = transform.rotation;
        Interact.canInteractEvent += CanInteract;
        Interact.interactEvent += InteractionDone;
        ThirdPersonController.MyInteractEvent += InteractionDone;
    }


    // Update is called once per frame
    void Update()
    {
        transform.rotation = angle;
    }
    private void InteractionDone()
    {
        interactText.SetActive(false);
        D.EnableDialog();
    }

    private void CanInteract(bool visible)
    {
        interactText.SetActive(visible);
    }

    private void OnDestroy()
    {
        Interact.canInteractEvent -= CanInteract;
    }
}
