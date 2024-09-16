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

    public GameObject Done1;

    private void Start()
    {
        firstTime = true;
        isOpened = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && (Notebook.activeSelf == false)) // Ouvrir le kiosque avec K
        {
            OpenKiosk();
        }
    }

    public void OpenKiosk()
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

    public void Note_Agriculture ()
    {
        if (Note_Agr.activeSelf == false)
        {
            Note_Agr.SetActive(true);
            Done1.SetActive(true);
            d.DialogIndex = 59;
            NM.PopUp_Noting();
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
}
