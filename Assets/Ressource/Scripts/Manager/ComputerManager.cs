using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerManager : MonoBehaviour
{
    public GameObject Browser;
    public GameObject ErrorMessage;
    public GameObject ErrorMessage2;
    public GameObject Notebook;

    public GameObject Note_Rev, Note_Pop;

    public Transform Pos1, Pos2, Pos3, Pos4, Pos5, Pos6;

    public GameObject DocInt, Fin, ListeRev, ListeCit, ListeElect, AnnFenz;

    public NotebookManager NM;
    public Dialogue d;

    private bool isOpened;
    private bool firstTime;

    private void Start()
    {
        firstTime = true;
        isOpened = false;

        Interact.interactEvent += OpenComputer;
    }

    /*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) && Notebook.activeSelf == false && d.isIntro == false) // Consulter l'ordinateur de la mairie avec L
        {
            OpenComputer();
        }
    }
    */

    public void OpenComputer() // Quand le joueur ouvre l'ordinateur
    {
        if (!Notebook.activeSelf)
        {
            if (firstTime) // Quand le joueur ouvre le carnet pour la première fois
            {
                d.DialogIndex = 70;
                d.EnableDialog();
                d.Dialog();
                firstTime = false;
            }
        }


        isOpened = !isOpened;
        Browser.SetActive(isOpened);
        ErrorMessage.SetActive(false);
        ErrorMessage2.SetActive(false);

        DocInt.transform.position = Pos1.transform.position;
        Fin.transform.position = Pos2.transform.position;
        ListeRev.transform.position = Pos3.transform.position;
        ListeCit.transform.position = Pos4.transform.position;
        ListeElect.transform.position = Pos5.transform.position;
        AnnFenz.transform.position = Pos6.transform.position;
    }


    public void Name_Sorting() // Trie les fichiers par nom
    {
        DocInt.transform.position = Pos1.transform.position;
        Fin.transform.position = Pos2.transform.position;
        ListeRev.transform.position = Pos6.transform.position;
        ListeCit.transform.position = Pos4.transform.position;
        ListeElect.transform.position = Pos5.transform.position;
        AnnFenz.transform.position = Pos3.transform.position;
    }
    public void Size_Sorting() // Trie les fichiers par taille
    {
        DocInt.transform.position = Pos1.transform.position;
        Fin.transform.position = Pos2.transform.position;
        ListeRev.transform.position = Pos4.transform.position;
        ListeCit.transform.position = Pos3.transform.position;
        ListeElect.transform.position = Pos6.transform.position;
        AnnFenz.transform.position = Pos5.transform.position;
    }
    public void Date_Sorting() // Trie les fichiers par date
    {
        DocInt.transform.position = Pos3.transform.position;
        Fin.transform.position = Pos1.transform.position;
        ListeRev.transform.position = Pos2.transform.position;
        ListeCit.transform.position = Pos5.transform.position;
        ListeElect.transform.position = Pos4.transform.position;
        AnnFenz.transform.position = Pos6.transform.position;
    }

    public void Open_Revenus()
    {
        if (Note_Rev.activeSelf == false)
        {
            Note_Rev.SetActive(true);
            d.DialogIndex = 58;
        }
        else
        {
            d.DialogIndex = 62;
        }

        d.EnableDialog();
        d.DialogTrigger();
    }

    public void Open_Population()
    {
        if (Note_Pop.activeSelf == false)
        {
            Note_Pop.SetActive(true);
            d.DialogIndex = 58;
        }
        else
        {
            d.DialogIndex = 62;
        }
        d.EnableDialog();
        d.DialogTrigger();
    }

    public void Open_Useless()
    {
        d.DialogIndex = 77;
        d.EnableDialog();
        d.DialogTrigger();
    }

    public void Open_Useless2()
    {
        d.DialogIndex = 80;
        d.EnableDialog();
        d.DialogTrigger();
    }

    public void OpenError()
    {
        ErrorMessage.SetActive(true);
    }

    public void OpenError2()
    {
        ErrorMessage2.SetActive(true);
    }

    public void CloseError()
    {
        ErrorMessage.SetActive(false);
        ErrorMessage2.SetActive(false);
    }

    public void Deconnexion()
    {
        Browser.SetActive(false);
    }

    private void OnDestroy()
    {
        Interact.interactEvent -= OpenComputer;
    }
}
