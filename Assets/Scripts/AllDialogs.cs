using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AllDialogs : MonoBehaviour
{
    public Dialogue D;
    private int DialogIndex;
    public GameObject SkipButton;
    public GameObject TextInput;
    public TMP_Text TextInput2;
    public GameObject Enterprise;
    public GameObject ValidatedName;

    public Entreprise E;


    private void Start()
    {
        EnableDialog();
        DialogIndex = 1;
        DialogList();
    }

    public void DialogTrigger()
    {
        if (D.dialogDone == true)
        {
            DialogIndex++;
            DialogList();
        }
        else if (D.dialogDone == false)
        {
            D.skipDialog = true;
        }
    }


   public void DialogList()
    {
        if (DialogIndex == 1) D.DialogFunction("???", "Bonjour !");
        if (DialogIndex == 2) D.DialogFunction("???", "Je vois que vous �tes un jeune entrepreneur ambitieux qui cherche � lancer l'entreprise de ses r�ves.");
        if (DialogIndex == 3) D.DialogFunction("Bebot", "Je me pr�sente, je suis Bebot.");
        if (DialogIndex == 4) D.DialogFunction("Bebot", "Je suis votre assistant personnel et ma t�che est de vous aider � accomplir cet objectif !");
        if (DialogIndex == 5)
        {
            D.DialogFunction("Bebot", "Et d'ailleurs, quel est votre nom ?");
            TextInput.gameObject.SetActive(true);
            SkipButton.gameObject.SetActive(false);
        }
        if (DialogIndex == 6)
        {
            D.DialogFunction("Bebot", "Enchant� " + E.UserName + ".");
            TextInput.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(true);
        }
        if (DialogIndex == 7) D.DialogFunction("Bebot", "Je suis ravi de vous accompagner dans cette aventure.");
        if (DialogIndex == 8) D.DialogFunction("Bebot", "Nous allons travailler ensemble afin de faire la meilleure entreprise possible !");
        if (DialogIndex == 9) D.DialogFunction("Bebot", "Avant toute chose, j'aimerais avoir plus d'informations sur celle ci.");
        if (DialogIndex == 10) D.DialogFunction("Bebot", "Quelle serait l'entreprise de tes r�ves ?");
        if (DialogIndex == 11)
        {
            Enterprise.gameObject.SetActive(true);
            SkipButton.gameObject.SetActive(false);
            DisableDialog();
        }
        if (DialogIndex == 12)
        {
            D.DialogFunction("Bebot", "Voil� l� t'as choisi ton truc");
            EnableDialog();
            Enterprise.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(true);
        }

        //if (DialogIndex == 4) DisableDialog();
    }

    public void EmptyNameChecker()
    {
        if(TextInput2.text.Length <= 1)
        {
            ValidatedName.gameObject.SetActive(false);
        }
        else if (TextInput2.text.Length > 1)
        {
            ValidatedName.gameObject.SetActive(true);
        }
    }

    public void EnableDialog()
    {
        D.Name.gameObject.SetActive(true);
        D.Text.gameObject.SetActive(true);
        D.BS.gameObject.SetActive(true);
        SkipButton.gameObject.SetActive(true);
    }

    public void DisableDialog()
    {
        D.Name.gameObject.SetActive(false);
        D.Text.gameObject.SetActive(false);
        D.BS.gameObject.SetActive(false);
        SkipButton.gameObject.SetActive(false);
    }
}
