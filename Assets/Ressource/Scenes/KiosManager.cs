using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiosManager : MonoBehaviour
{

    public GameObject Board;
    private bool isOpened;
    private bool firstTime;

    public Dialogue d;

    private void Start()
    {
        firstTime = true;
        isOpened = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)) // Ouvrir le kiosque avec K
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
}
