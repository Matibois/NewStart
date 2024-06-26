using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllDialogs : MonoBehaviour
{
    public Dialogue D;
    private int DialogIndex;
    public GameObject SkipButton;
    public GameObject TextInput;

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
        if (DialogIndex == 2) D.DialogFunction("???", "Je vois que vous êtes un jeune entrepreneur ambitieux qui cherche à lancer l'entreprise de ses rêves.");
        if (DialogIndex == 3) D.DialogFunction("Bebot", "Je me présente, je suis Bebot.");
        if (DialogIndex == 4) D.DialogFunction("Bebot", "Je suis votre assistant personnel et ma tâche est de vous aider à accomplir cet objectif !");
        if (DialogIndex == 5)
        {
            D.DialogFunction("Bebot", "Et d'ailleurs, quel est votre nom ?");
            TextInput.gameObject.SetActive(true);
            SkipButton.gameObject.SetActive(false);
        }
        if (DialogIndex == 6)
        {
            D.DialogFunction("Bebot", "Enchanté Player");
            TextInput.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(true);
        }
        if (DialogIndex == 7) D.DialogFunction("Bebot", "Je suis ravi de vous accompagner dans cette aventure.");
        if (DialogIndex == 8) D.DialogFunction("Bebot", "Nous allons travailler ensemble afin de faire la meilleure entreprise possible !");
        if (DialogIndex == 9) D.DialogFunction("Bebot", "Avant toute chose, j'aimerais avoir plus d'informations sur celle ci.");
        if (DialogIndex == 10)
        {
            D.DialogFunction("Bebot", "Dans quel domaine allons-nous nous installer ?");
            TextInput.gameObject.SetActive(true);
            SkipButton.gameObject.SetActive(false);
        }

        //if (DialogIndex == 4) DisableDialog();
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
