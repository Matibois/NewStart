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

    public void R_Bookmarks_Out()
    {
        R_Bookmarks.GetComponent<Animator>().Play("Bookmark");
        
    }

    public void R_Bookmarks_In()
    {
        R_Bookmarks.GetComponent<Animator>().Play("B_InMove");
    }
}
