using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private float delay = 0.03f;
    [SerializeField] private TMP_Text LeTexte;
    [SerializeField] private string fullText;
    [SerializeField] private GameObject SkipButton;
    [SerializeField] private GameObject EnterpriseChoice;
    [SerializeField] private GameObject ValidatedName;
    [SerializeField] private GameObject darkBackground;

    public BoxSize BS;
    [SerializeField] private GameObject nameGO;
    [SerializeField] private GameObject dialogueGO;
    private TMP_Text speakerTMP;
    private TMP_Text dialogueTMP;
    private RectTransform nameTransform;
    private RectTransform dialogueTransform;
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_InputField entrepriseNameInput;

    private bool dialogDone = true;
    private bool skipDialog = false;
    private bool codeChar;
    public bool isIntro = true;

    private int DialogIndex = 0;
    private readonly AllDialogs AllDialog = new();
    private Dictionary<int, Dictionary<string, string>> activeDialog;


    public GameObject NotebookT;
    public NotebookManager NM;

    private new string name = "chips";
    private string entrepriseName;

    private void Start()
    {
        AllDialog.InitIntro();
        AllDialog.InitMairie();
        AllDialog.InitMaire();

        activeDialog = AllDialog.mairie;

        speakerTMP = nameGO.GetComponent<TMP_Text>();
        dialogueTMP = dialogueGO.GetComponent<TMP_Text>();
        nameTransform = nameGO.GetComponent<RectTransform>();
        dialogueTransform = dialogueGO.GetComponent<RectTransform>();

        dialogDone = true;
        skipDialog = false;

        Interact.interactEvent += interaction;

        EnableDialog();
        Dialog();
    }


    public void Named()
    {
        name = nameInput.text;
        print("named " + name + " from dialogue");
    }
    public void EnterpriseNamed()
    {
        entrepriseName = entrepriseNameInput.text;
    }
    public void EmptyNameChecker()
    {

        if (!string.IsNullOrWhiteSpace(nameInput.text))
        {
            nameInput.text = nameInput.text.Trim();
            ValidatedName.gameObject.SetActive(true);
        }
    }

    private void interaction(Interact.ID id)
    {
        print("interaction dialogue");
        switch (id)
        {
            case Interact.ID.Bebot:

                break;
            case Interact.ID.Commer�ant:

                break;
            case Interact.ID.Kiosque:

                break;
            case Interact.ID.Mairie:
                print("mairie");
                activeDialog = AllDialog.maire;
                break;

        }
        EnableDialog();
        Dialog();
    }
    public void DialogTrigger()
    {
        if (dialogDone == true)
        {
            DialogIndex++;
            Dialog();
        }
        else if (dialogDone == false)
        {
            skipDialog = true;
        }
    }

    public void BoxSizeChoice(string text)
    {
        int boxsize = BS.BoxSizeChoice(text);

        switch (boxsize)
        {
            case 1:
                nameTransform.anchoredPosition = new Vector2(-154.7f, -21.3f);
                dialogueTransform.anchoredPosition = new Vector2(-76.4f, -74.2f);
                break;
            case 2:
                nameTransform.anchoredPosition = new Vector2(-154.7f, 27.2f);
                dialogueTransform.anchoredPosition = new Vector2(-76.4f, -29f);
                break;
            case 3:
                nameTransform.anchoredPosition = new Vector2(-154.7f, 100.3f);
                dialogueTransform.anchoredPosition = new Vector2(-76.4f, 41.5f);
                break;
        }

    }
    IEnumerator ShowText(string text)
    {
        dialogDone = false;
        LeTexte.text = "";

        bool insideTag = false;
        string currentText = "";

        for (int i = 0; i < text.Length; i++)
        {
            currentText += text[i];

            if (text[i] == '<')
            {
                insideTag = true;
            }
            else if (text[i] == '>')
            {
                insideTag = false;
            }

            if (!insideTag && !skipDialog)
            {
                LeTexte.text = currentText;
                yield return new WaitForSeconds(delay);
            }
        }

        LeTexte.text = text;
        dialogDone = true;
        skipDialog = false;
    }


    public void DialogTrigger()
    {
        if (dialogDone == true)
        {
            DialogIndex++;
            Dialog();
        }
        else if (dialogDone == false)
        {
            skipDialog = true;
        }
    }

    public void Dialog()
    {
        if (activeDialog == AllDialog.intro) IntroDialog();
        else MairieDialog();

    }

    public void EnableDialog()
    {
        nameGO.SetActive(true);
        dialogueGO.SetActive(true);
        BS.gameObject.SetActive(true);
        SkipButton.gameObject.SetActive(true);
    }
    public void DisableDialog()
    {
        nameGO.SetActive(false);
        dialogueGO.SetActive(false);
        BS.gameObject.SetActive(false);
        SkipButton.gameObject.SetActive(false);
    }
    private void IntroDialog()
    {
        print("intro");
        if (DialogIndex == 4) // Bebot demande notre blaze
        {
            nameInput.gameObject.SetActive(true);
            SkipButton.gameObject.SetActive(false);
        }
        else if (DialogIndex == 5) // Te prends pas la t�te � comprendre, je t'explique en appel, ou en IRL
        {
            var dictionnaryIndex = AllDialog.intro[DialogIndex]; // copie colle ces deux lignes, remplace DialogIndex par l'index du dialogue que tu veux
            dictionnaryIndex["dialogue"] += name + " ! "; //  dictionnaryIndex["dialogue"] c'est le dialogue, c'est une string
            nameInput.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(true);
        }
        else if (DialogIndex == 10) // On enl�ve le dialogue pour rentrer le nom de l'entrepriser et l'activit�
        {
            EnterpriseChoice.gameObject.SetActive(true);
            SkipButton.gameObject.SetActive(false);
            DisableDialog();
        }
        else if (DialogIndex == 11)
        {
            EnableDialog();
            EnterpriseChoice.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(true);
        }
        else if (DialogIndex == 19)
        {
            
            darkBackground.GetComponent<Animator>().Play("FadeOut");
            DisableDialog();
        }
        else if (DialogIndex == 20)
        {
            EnableDialog();
        }
        else if (DialogIndex == 25)
        {
            DisableDialog();
            isIntro = false;
            NotebookT.GetComponent<Animator>().Play("Sliding");
        }
        else if (DialogIndex == 26)
        {
            EnableDialog();
            NotebookT.GetComponent<Button>().enabled = false;
        }
        else if (DialogIndex == 28)
        {
            SkipButton.gameObject.SetActive(false);
            delay = 0.01f;
            NM.A.interactable = true;
        }
        else if (DialogIndex == 29)
        {
            delay = 0.03f;
            SkipButton.gameObject.SetActive(true);
        }
        else if (DialogIndex == 36)
        {
            DisableDialog();
            NotebookT.GetComponent<Button>().enabled = true;
            NM.canClose = true;
        }
        else if (DialogIndex == 37)
        {
            EnableDialog();
        }
        else if (DialogIndex == 40)
        {
            DisableDialog();
        }


        
        if (DialogIndex == 60)
        {
            NM.PopUp_Noting();
        }
        if (DialogIndex == 55 || DialogIndex == 62 || DialogIndex == 64 || DialogIndex == 66 || DialogIndex == 68 || DialogIndex == 76 || DialogIndex == 80 || DialogIndex == 83)
        {
            DisableDialog();

        }

        if (DialogIndex == 50 )
        {
            var dictionnaryIndex = AD.dialogues[DialogIndex];
            Debug.Log("Kiosque");
        }

        if (DialogIndex == 60)
        {
            var dictionnaryIndex = AD.dialogues[DialogIndex];
        }

        if (DialogIndex == 70)
        {
            var dictionnaryIndex = AD.dialogues[DialogIndex];
            Debug.Log("Mairie");
        }

        /*
        if (DialogIndex == AllDialog.intro.Count)
        {
            DisableDialog();
            DialogIndex = 0;

        }
        */
        else
        {
            var dictionnaryIndex = AllDialog.intro[DialogIndex];
            BoxSizeChoice(dictionnaryIndex["dialogue"]);
            StartCoroutine(ShowText(dictionnaryIndex["dialogue"]));
        }
    }
    private void MairieDialog()
    {
        if (DialogIndex == AllDialog.mairie.Count) 
        {
            DisableDialog();
            DialogIndex = 0;
            print("dialog end 0");

        }
        else
        {
            print("outro");
            var dictionnaryIndex = AllDialog.mairie[DialogIndex];
            BoxSizeChoice(dictionnaryIndex["dialogue"]);
            StartCoroutine(ShowText(dictionnaryIndex["dialogue"]));
        }
    }
    private void MaireDialog()
    {
        if (DialogIndex == activeDialog.Count)
        {
            DisableDialog();
            DialogIndex = 0;
            print("dialog end 0");

        }
        else
        {
            print("outro");
            var dictionnaryIndex = AllDialog.mairie[DialogIndex];
            BoxSizeChoice(dictionnaryIndex["dialogue"]);
            StartCoroutine(ShowText(dictionnaryIndex["dialogue"]));
        }
    }

    /*private void DefaultDialog()
    {
        if (DialogIndex == activeDialog.Count)
        {
            DisableDialog();
            DialogIndex = 0;
            print("dialog end 0");

        }
        else
        {
            var dictionnaryIndex = activeDialog[DialogIndex];
            BoxSizeChoice(dictionnaryIndex["dialogue"]);
            StartCoroutine(ShowText(dictionnaryIndex["dialogue"]));
        }
    }*/

    private void OnDestroy()
    {
        Interact.interactEvent -= interaction;
        StopAllCoroutines();
    }







}