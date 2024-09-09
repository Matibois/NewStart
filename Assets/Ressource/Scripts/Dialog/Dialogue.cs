using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private float delay = 0.05f;
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
    private readonly AllDialogs AD = new();

    public GameObject NotebookT;
    public NotebookManager NM;

    private new string name = "chips";
    private string entrepriseName;

    private void Start()
    {
        AD.InitDictionnary();

        speakerTMP = nameGO.GetComponent<TMP_Text>();
        dialogueTMP = dialogueGO.GetComponent<TMP_Text>();
        nameTransform = nameGO.GetComponent<RectTransform>();
        dialogueTransform = dialogueGO.GetComponent<RectTransform>();

        dialogDone = true;
        skipDialog = false;
        
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

    public void BoxSizeChoice(string name, string text)
    {
        LeTexte.text = "";
        speakerTMP.text = name;
        if (text.Length >= 210) //Large Box 210
        {
            BS.DisplayBox(3);
            nameTransform.anchoredPosition = new Vector2(-154.7f, 100.3f);
            dialogueTransform.anchoredPosition = new Vector2(-76.4f, 41.5f);
        }
        else if (text.Length > 105) //Medium Box
        {
            BS.DisplayBox(2);
            nameTransform.anchoredPosition  = new Vector2(-154.7f, 27.2f);
            dialogueTransform.anchoredPosition = new Vector2(-76.4f, -29f);
        }
        else // Small Box 
        {
            BS.DisplayBox(1);
            nameTransform.anchoredPosition  = new Vector2(-154.7f, -21.3f);
            dialogueTransform.anchoredPosition = new Vector2(-76.4f, -74.2f);
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
        if (DialogIndex == 4) // Bebot demande notre blaze
        {
            nameInput.gameObject.SetActive(true);
            SkipButton.gameObject.SetActive(false);
        }
        else if (DialogIndex == 5) // Te prends pas la tête à comprendre, je t'explique en appel, ou en IRL
        {
            var dictionnaryIndex = AD.dialogues[DialogIndex]; // copie colle ces deux lignes, remplace DialogIndex par l'index du dialogue que tu veux
            dictionnaryIndex["dialogue"] += name + " ! "; //  dictionnaryIndex["dialogue"] c'est le dialogue, c'est une string
            nameInput.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(true);
        }
        else if (DialogIndex == 10) // On enlève le dialogue pour rentrer le nom de l'entrepriser et l'activité
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
        }
        else if (DialogIndex == 28)
        {
            SkipButton.gameObject.SetActive(false);
            NM.A.interactable = true;
        }
        else if (DialogIndex == 29)
        {
            SkipButton.gameObject.SetActive(true);
        }
        if (DialogIndex == AD.dialogues.Count)
        {
            DisableDialog();
        }
        else
        {
            var dictionnaryIndex = AD.dialogues[DialogIndex];
            BoxSizeChoice(dictionnaryIndex["speaker"], dictionnaryIndex["dialogue"]);
            StartCoroutine(ShowText(dictionnaryIndex["dialogue"]));
        }

    }

    public void EmptyNameChecker( )
    {
        
        if (!string.IsNullOrWhiteSpace(nameInput.text))
        { 
            nameInput.text = nameInput.text.Trim();
            ValidatedName.gameObject.SetActive(true);
        }
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
}
