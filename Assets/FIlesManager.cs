using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIlesManager : MonoBehaviour
{

    //Notebooks Gameobjects
    public GameObject R_Closed;
    public GameObject R_Opened;
    public GameObject B_Closed;
    public GameObject B_Opened;
    public GameObject G_Closed;
    public GameObject G_Opened;

    //Texts in notebooks
    public GameObject R_Player;
    public GameObject R_Enteprise;
    public GameObject B_Player;
    public GameObject B_Enteprise;
    public GameObject G_Player;
    public GameObject G_Enteprise;

    public GameObject R_Bookmarks;
    public GameObject B_Bookmarks;
    public GameObject G_Bookmarks;

    private bool redState = false;
    private bool blueState = false;
    private bool greenState = false;

    private void Start()
    {
        BookSelection(0);
    }

    public void R_Switch()
    {
        redState = !redState;
        R_Closed.gameObject.SetActive(!redState);
        R_Opened.gameObject.SetActive(redState);
    }

    public void B_Switch()
    {
        blueState = !blueState;
        B_Closed.gameObject.SetActive(!blueState);
        B_Opened.gameObject.SetActive(blueState);
    }

    public void G_Switch()
    {
        greenState = !greenState;
        G_Closed.gameObject.SetActive(!greenState);
        G_Opened.gameObject.SetActive(greenState);
    }

    public void BookSelection(int bookSelected)
    {

        switch (bookSelected)
        {
            case 0:
                R_Bookmarks.GetComponent<Animator>().Play("B_InStill");
                redState = false;
                B_Bookmarks.GetComponent<Animator>().Play("B_InStill");
                blueState = false;
                G_Bookmarks.GetComponent<Animator>().Play("B_InStill");
                greenState = false;
                break;

            case 1:
                if (redState == false) R_Bookmarks.GetComponent<Animator>().Play("Bookmark");
                redState = true;
                if (blueState == true) B_Bookmarks.GetComponent<Animator>().Play("B_InMove");
                blueState = false;
                if (greenState == true) G_Bookmarks.GetComponent<Animator>().Play("B_InMove");
                greenState = false;
                break;

            case 2:
                if (redState == true) R_Bookmarks.GetComponent<Animator>().Play("B_InMove");
                redState = false;
                if (blueState == false) B_Bookmarks.GetComponent<Animator>().Play("Bookmark");
                blueState = true;
                if (greenState == true) G_Bookmarks.GetComponent<Animator>().Play("B_InMove");
                greenState = false;
                break;

            case 3:
                if (redState == true) R_Bookmarks.GetComponent<Animator>().Play("B_InMove");
                redState = false;
                if (blueState == true) B_Bookmarks.GetComponent<Animator>().Play("B_InMove");
                blueState = false;
                if (greenState == false) G_Bookmarks.GetComponent<Animator>().Play("Bookmark");
                greenState = true;
                break;

        }

    }

    public void R_Selected()
    {
        BookSelection(1);
    }

    public void B_Selected()
    {
        BookSelection(2);
    }

    public void G_Selected()
    {
        BookSelection(3);
    }
}
