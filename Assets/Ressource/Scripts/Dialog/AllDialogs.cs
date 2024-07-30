using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class AllDialogs : MonoBehaviour
{


    public Dialogue D;
    private int DialogIndex = 0;
    public GameObject SkipButton;
    public GameObject TextInput;
    public TMP_Text TextInput2;
    public GameObject Enterprise;
    public GameObject ValidatedName;

    public Entreprise E;

    private Dictionary<int, Dictionary<string, string>> dialogues;

    private void Start()
    {
        InitDictionnary();
        EnableDialog();
        DialogList();
    }

    private void InitDictionnary()
    {
        dialogues = new Dictionary<int, Dictionary<string, string>>
        {
            { 0, new Dictionary<string, string> { { "speaker", "???" }, { "dialogue", "Bonjour ! " } } },
            { 1, new Dictionary<string, string> { { "speaker", "???" }, { "dialogue", "Je vois que vous �tes un jeune entrepreneur ambitieux qui cherche � lancer l'entreprise de ses r�ves. " } } },
            { 2, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Je me pr�sente, je suis <color=yellow>Bebot.</color> " } } },
            { 3, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Je suis votre assistant personnel et ma t�che est de vous aider � accomplir cet objectif ! " } } },
            { 4, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Et d'ailleurs, quel est votre nom ? " } } },
            { 5, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", $"Enchant� " } } },
            { 6, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Je suis ravi de vous accompagner dans cette aventure. " } } },
            { 7, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Nous allons travailler ensemble afin de faire la meilleure entreprise possible ! " } } },
            { 8, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Avant toute chose, j'aimerais avoir plus d'informations sur celle ci. " } } },
            { 9, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Quelle serait l'entreprise de tes r�ves ? " } } },
            { 10, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } }, // c'est l� o� on va mettre le nom de l'entreprise
            { 11, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Formidable ! Votre projet � du potentiel. " } } },
            { 12, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Mais avant de cr�er r�ellement votre entreprise nous allons d'abord devoir r�colter un certain nombre d'informations. " } } },
            { 13, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Sur les villes environnantes, leur populations, les clients et concurrents potentiels, les tendances du moment... " } } },
            { 14, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "On appelle �a, l'�tude de march� ! " } } },
            { 15, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Cette �tude � pour objectif d'analyser l'offre et la demande sur notre march� afin de mettre en place une strat�gie marketing. " } } },
            { 16, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Les informations que nous allons r�colter vont nous permettre d'orienter nos choix commerciaux. " } } },
            { 17, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Ne vous inqui�tez pas, je serai � vos c�t�s tout au long du processus! " } } },
            { 18, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Pour commencer, et si on sortait ? " } } },
            { 19, new Dictionary<string, string> { { "speaker", "Th�o" }, { "dialogue", "Et voil� pour l'introduction " } } },
            { 20, new Dictionary<string, string> { { "speaker", "Matt" }, { "dialogue", "s'ma bite " } } },
            { 21, new Dictionary<string, string> { { "speaker", "Matt" }, { "dialogue", "quand tu veux rajouter du dialogue, copie  colle la derniere ligne, rajoute lui une virgule, et change le nombre au d�but de ta ligne, et voilaaa " } } },
            { 22, new Dictionary<string, string> { { "speaker", "Matt" }, { "dialogue", "et si tu veux acc�der � un dialogue en particulier depuis le code, regarde comment j'ai fais pour rajouter l'username dans la fonction dialoglist � l'index 5" } } }
        };
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
        if (DialogIndex == 4)
        {
            TextInput.gameObject.SetActive(true);
            SkipButton.gameObject.SetActive(false);
        }
        else if (DialogIndex == 5)
        {
            var dictionnaryIndex = dialogues[DialogIndex]; 
            dictionnaryIndex["dialogue"] += E.GetUserName() + "! ";
            TextInput.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(true);
        }
        else if (DialogIndex == 10)
        {
            Enterprise.gameObject.SetActive(true);
            SkipButton.gameObject.SetActive(false);
            DisableDialog();
        }
        else if (DialogIndex == 11)
        {
            EnableDialog();
            Enterprise.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(true);
        }
        else if (DialogIndex == 19)
        {
            EnableDialog();
            Enterprise.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(true);
        }

        if (DialogIndex > dialogues.Count -1) { DisableDialog(); }
        else
        {
            var dictionnaryIndex = dialogues[DialogIndex];
            D.DialogFunction(dictionnaryIndex["speaker"], dictionnaryIndex["dialogue"]);
        }

    }

    public void EmptyNameChecker()
    {
        if (TextInput2.text.Length <= 1)
        {
            ValidatedName.gameObject.SetActive(false);
        }
        else
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
