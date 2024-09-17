using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class NotebookManager : MonoBehaviour
{
    public GameObject Notebook;
    public GameObject Kiosk;
    public GameObject Computer;

    private bool isOpened;
    private bool firstTime;
    public int secondTime;
    private bool firstTimeF;
    public bool canClose;

    // Intercalaires
    public Button A, B, C, D;
    public GameObject BM_Farm;
    public GameObject BM_City;
    public GameObject BM_Beach;
    public GameObject BM_Mountain;

    public GameObject BM_Farm2;
    public GameObject BM_City2;
    public GameObject BM_Beach2;
    public GameObject BM_Mountain2;

    public GameObject BM_Postcards;
    public GameObject BM_Glossary;
    public GameObject BM_Objectives;

    public GameObject P_Farm;
    public GameObject P_City;
    public GameObject P_Beach;
    public GameObject P_Mountain;

    public Dialogue d;

    public GameObject PopUp_Note;

    public GameObject Note1, Note2A, Note2B, Note3;
    public GameObject Validate1, Validate2, Validate3;


    private void Start()
    {
        isOpened = false;
        firstTime = true;
        firstTimeF = true;
        secondTime = 0;
        canClose = true;

        A.interactable = false;
        B.interactable = false;
        C.interactable = false;
        D.interactable = false;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && d.isIntro == false && canClose == true && Kiosk.activeSelf == false && Computer.activeSelf == false) // Ouvrir le carnet avec T
        {
            OpenNotebook();

        }
    }

    public void OpenNotebook() //Ouvrir le carnet
    {
        if (firstTime) // Quand le joueur ouvre le carnet pour la première fois
        {
            d.DialogTrigger();
            firstTime = false;

            canClose = false;
        }

        if (secondTime < 4) secondTime += 1;
        if (secondTime == 2) // Quand le joueur ferme le carnet pour la première fois
        {
            d.DialogTrigger();
            secondTime += 5;
        }

        Objectif_Update();

        isOpened = !isOpened;
        Notebook.SetActive(isOpened);

        BM_Farm.SetActive(true);
        BM_City.SetActive(true);
        BM_Beach.SetActive(true);
        BM_Mountain.SetActive(true);
        BM_Farm2.SetActive(false);
        BM_City2.SetActive(false);
        BM_Beach2.SetActive(false);
        BM_Mountain2.SetActive(false);
        BM_Glossary.SetActive(false);
        P_Farm.SetActive(false);
        P_City.SetActive(false);
        P_Beach.SetActive(false);
        P_Mountain.SetActive(false);
        BM_Postcards.SetActive(true);
        BM_Objectives.SetActive(false);
    }

    public void Farm() // C'est hyper crade, mais vas y je veux juste que ça fonctionne
    {
        if (firstTimeF) // Quand le joueur ouvre les pages sur Fenzy Farm pour la première fois
        {
            d.DialogTrigger();
            firstTimeF = false;
        }

        BM_Farm.SetActive(false);
        BM_City.SetActive(true);
        BM_Beach.SetActive(true);
        BM_Mountain.SetActive(true);
        BM_Farm2.SetActive(true);
        BM_City2.SetActive(false);
        BM_Beach2.SetActive(false);
        BM_Mountain2.SetActive(false);
        BM_Postcards.SetActive(false);
        BM_Glossary.SetActive(false);
        P_Farm.SetActive(true);
        P_City.SetActive(false);
        P_Beach.SetActive(false);
        P_Mountain.SetActive(false);
        BM_Objectives.SetActive(false);
    }
    public void City() // Pages de notes pour Urban City
    {
        BM_Farm.SetActive(true);
        BM_City.SetActive(false);
        BM_Beach.SetActive(true);
        BM_Mountain.SetActive(true);
        BM_Farm2.SetActive(false);
        BM_City2.SetActive(true);
        BM_Beach2.SetActive(false);
        BM_Mountain2.SetActive(false);
        BM_Postcards.SetActive(false);
        BM_Glossary.SetActive(false);
        P_Farm.SetActive(false);
        P_City.SetActive(true);
        P_Beach.SetActive(false);
        P_Mountain.SetActive(false);
        BM_Objectives.SetActive(false);
    }
    public void Beach() // Pages de notes pour Palm Beach
    {
        BM_Farm.SetActive(true);
        BM_City.SetActive(true);
        BM_Beach.SetActive(false);
        BM_Mountain.SetActive(true);
        BM_Farm2.SetActive(false);
        BM_City2.SetActive(false);
        BM_Beach2.SetActive(true);
        BM_Mountain2.SetActive(false);
        BM_Postcards.SetActive(false);
        BM_Glossary.SetActive(false);
        P_Farm.SetActive(false);
        P_City.SetActive(false);
        P_Beach.SetActive(true);
        P_Mountain.SetActive(false);
        BM_Objectives.SetActive(false);
    }
    public void Mountain() // Pages de notes pour White Mountain
    {
        BM_Farm.SetActive(true);
        BM_City.SetActive(true);
        BM_Beach.SetActive(true);
        BM_Mountain.SetActive(false);
        BM_Farm2.SetActive(false);
        BM_City2.SetActive(false);
        BM_Beach2.SetActive(false);
        BM_Mountain2.SetActive(true);
        BM_Postcards.SetActive(false);
        BM_Glossary.SetActive(false);
        P_Farm.SetActive(false);
        P_City.SetActive(false);
        P_Beach.SetActive(false);
        P_Mountain.SetActive(true);
        BM_Objectives.SetActive(false);
    }

    public void Map() // La carte (cartes postales)
    {
        BM_Farm.SetActive(true);
        BM_City.SetActive(true);
        BM_Beach.SetActive(true);
        BM_Mountain.SetActive(true);
        BM_Farm2.SetActive(false);
        BM_City2.SetActive(false);
        BM_Beach2.SetActive(false);
        BM_Mountain2.SetActive(false);
        BM_Postcards.SetActive(true);
        BM_Glossary.SetActive(false);
        P_Farm.SetActive(false);
        P_City.SetActive(false);
        P_Beach.SetActive(false);
        P_Mountain.SetActive(false);
        BM_Objectives.SetActive(false);
    }

    public void Glossary() // Glossaire
    {
        BM_Farm.SetActive(true);
        BM_City.SetActive(true);
        BM_Beach.SetActive(true);
        BM_Mountain.SetActive(true);
        BM_Farm2.SetActive(false);
        BM_City2.SetActive(false);
        BM_Beach2.SetActive(false);
        BM_Mountain2.SetActive(false);
        BM_Postcards.SetActive(false);
        BM_Glossary.SetActive(true);
        P_Farm.SetActive(false);
        P_City.SetActive(false);
        P_Beach.SetActive(false);
        P_Mountain.SetActive(false);
        BM_Objectives.SetActive(false);
    }

    public void Objectives() // Objectifs
    {
        BM_Farm.SetActive(true);
        BM_City.SetActive(true);
        BM_Beach.SetActive(true);
        BM_Mountain.SetActive(true);
        BM_Farm2.SetActive(false);
        BM_City2.SetActive(false);
        BM_Beach2.SetActive(false);
        BM_Mountain2.SetActive(false);
        BM_Postcards.SetActive(false);
        BM_Glossary.SetActive(false);
        P_Farm.SetActive(false);
        P_City.SetActive(false);
        P_Beach.SetActive(false);
        P_Mountain.SetActive(false);
        BM_Objectives.SetActive(true);
    }

    public void PopUp_Noting()
    {
        PopUp_Note.GetComponent<Animator>().Play("PopUp_Noting");
    }

    public void Objectif_Update()
    {
        if (Note1.activeSelf == true)
        {
            Validate1.SetActive(true);
        }
        if (Note2A.activeSelf == true && Note2B.activeSelf == true)
        {
            Validate2.SetActive(true);
        }
    }
}
