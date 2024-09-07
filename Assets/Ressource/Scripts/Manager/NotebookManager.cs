using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NotebookManager : MonoBehaviour
{
    public GameObject Notebook;
    private bool isOpened;

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

    public GameObject P_Farm;
    public GameObject P_City;
    public GameObject P_Beach;
    public GameObject P_Mountain;

    public Dialogue d;

    private void Start()
    {
        isOpened = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && d.isIntro == false)
        {
            OpenNotebook();
        }
    }

    public void OpenNotebook()
    {
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
    }

    public void Farm() // C'est hyper crade, mais vas y je veux juste que ça fonctionne
    {
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
    }
    public void City() // C'est hyper crade, mais vas y je veux juste que ça fonctionne
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
    }
    public void Beach() // C'est hyper crade, mais vas y je veux juste que ça fonctionne
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
    }
    public void Mountain() // C'est hyper crade, mais vas y je veux juste que ça fonctionne
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
    }

    public void Map()
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
    }

    public void Glossary()
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
    }
    
}
