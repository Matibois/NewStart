using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Interact : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject player;
    [SerializeField] GameObject parentObject;

    Material[] original;
    Material[] outline;
    Material[] mats;

    Ray ray;
    RaycastHit hit;
    private bool canInterract = false;

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
            parentObject.GetComponent<Renderer>().materials = outline;
            canInterract = true;
            print("collide");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            parentObject.GetComponent<Renderer>().materials = original;
            canInterract = false;
            print("NO collide");
        }
    }


    /*public void OnMouseDown()
    {
        //menu.SetActive(true);
        //player.SetActive(false);
        print("click");
        Time.timeScale = (Time.timeScale == 0) ? 1 : 0;
    }*/


    void Update()
    {
        if (canInterract)
        {

            ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            if (Physics.Raycast(ray, out hit))
            {
                if (Mouse.current.leftButton.wasPressedThisFrame)
                    print(hit.collider.name);
            }
        }
    }
}
