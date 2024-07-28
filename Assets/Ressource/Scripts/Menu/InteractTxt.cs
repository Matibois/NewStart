using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractTxt : MonoBehaviour
{
    [SerializeField] GameObject interactText;

    Quaternion angle;

    void Start()
    {
        angle = transform.rotation;
        Interact.canInteractEvent += Interaction;
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
    }

    private void Interaction(bool visible)
    {
        interactText.SetActive(visible);
    }

    private void OnDestroy()
    {
        Interact.canInteractEvent -= Interaction;
    }
}
