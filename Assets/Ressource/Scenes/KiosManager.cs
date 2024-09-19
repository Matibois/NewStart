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

    public void OpenKiosk(Interact.ID id)
    {
        if(!Notebook.activeSelf && id == Interact.ID.Kiosque)
        {
            isOpened = !isOpened;
            Board.SetActive(isOpened);
        }
    }

    public void Note_Agriculture ()
    {
        if (Note_Agr.activeSelf == false)
        {
            Note_Agr.SetActive(true);
        }
        else d.DialogDejanote();
    }

    public void Note_Inutile()
    {
        d.DialogInfoKiosk(false);
        d.EnableDialog();
        d.DialogTrigger();
    }

    private void OnDestroy()
    {
        Interact.interactEvent -= OpenKiosk;
    }
}
