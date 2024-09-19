using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiosManager : MonoBehaviour
{

    public GameObject Board;
    public GameObject Notebook;
    private bool isOpened;
    private bool firstTime;


    public NotebookManager NM;
    public Dialogue d;

    public GameObject Note_Agr;

    private void Start()
    {
        firstTime = true;
        isOpened = false;

        Interact.interactEvent += OpenKiosk;
    }

    public void OpenKiosk()
    {
        if(!Notebook.activeSelf)
        {
            if (firstTime) // Quand le joueur ouvre le carnet pour la première fois
            {
                d.DialogIndex = 49;
                d.EnableDialog();
                d.DialogTrigger();
                firstTime = false;
            }

            isOpened = !isOpened;
            Board.SetActive(isOpened);
        }
    }

    public void Note_Agriculture ()
    {
        if (Note_Agr.activeSelf == false)
        {
            Note_Agr.SetActive(true);
            d.DialogIndex = 59;
        }
        else
        {
            d.DialogIndex = 62;
        }
        d.EnableDialog();
        d.DialogTrigger();
    }

    public void Note_Inutile_1()
    {
        d.DialogIndex = 64;
        d.EnableDialog();
        d.DialogTrigger();
    }

    public void Note_Inutile_2()
    {
        d.DialogIndex = 66;
        d.EnableDialog();
        d.DialogTrigger();
    }

    private void OnDestroy()
    {
        Interact.interactEvent -= OpenKiosk;
    }
}
