using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class EntepriseChoiceUI : MonoBehaviour
{
    public bool Name = false;
    public bool Domain = false;
    public TMP_Text eName;
    public GameObject ValidationArrow;

    public GameObject H_Cloth;
    public GameObject H_Grocery;
    public GameObject H_Help;
    public GameObject H_Bike;


    public void NameValidation()
    {
        if (eName.text.Length <= 1)
        {
            Name = false;
        }
        else 
        {
            Name = true;
        }
    }
    // PARREIL SI PAS DE BOUTONS SELECTIONES


    public void DomainSelection()
    {
        Domain = true;
        if(EventSystem.current.currentSelectedGameObject.name == "Cloth")
        {
            H_Cloth.gameObject.SetActive(true);
            H_Grocery.gameObject.SetActive(false);
            H_Help.gameObject.SetActive(false);
            H_Bike.gameObject.SetActive(false);
        }
        else if (EventSystem.current.currentSelectedGameObject.name == "Bike")
        {
            H_Cloth.gameObject.SetActive(false);
            H_Grocery.gameObject.SetActive(false);
            H_Help.gameObject.SetActive(false);
            H_Bike.gameObject.SetActive(true);
        }
        else if (EventSystem.current.currentSelectedGameObject.name == "Help")
        {
            H_Cloth.gameObject.SetActive(false);
            H_Grocery.gameObject.SetActive(false);
            H_Help.gameObject.SetActive(true);
            H_Bike.gameObject.SetActive(false);
        }
        else if (EventSystem.current.currentSelectedGameObject.name == "Grocery")
        {
            H_Cloth.gameObject.SetActive(false);
            H_Grocery.gameObject.SetActive(true);
            H_Help.gameObject.SetActive(false);
            H_Bike.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        /*
        if (EventSystem.current.currentSelectedGameObject.name == null || EventSystem.current.currentSelectedGameObject == null)
        {
            Domain = false;
            return;
        }
        else if(EventSystem.current.currentSelectedGameObject.name == "Cloth" || EventSystem.current.currentSelectedGameObject.name == "Bike" || EventSystem.current.currentSelectedGameObject.name == "Grocery" || EventSystem.current.currentSelectedGameObject.name == "Help")
        {
            Domain = true;
        }
        else
        {
            Domain = false;
        }
        DoubleSelection();
        */
    }

    public void DoubleSelection()
    {
        if(Name && Domain)
        {
            ValidationArrow.gameObject.SetActive(true);
        }
        else
        {
            ValidationArrow.gameObject.SetActive(false);
        }
    }
}
