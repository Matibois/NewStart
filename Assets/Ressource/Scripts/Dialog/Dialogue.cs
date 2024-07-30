using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private float delay = 0.05f;
    [SerializeField] private TMP_Text LeTexte;
    [SerializeField] private string fullText;

    public BoxSize BS;
    public GameObject Name;
    public GameObject Text;
    [SerializeField] private RectTransform textTransform;
    [SerializeField] private RectTransform nameTransform;

    public bool dialogDone;
    public bool skipDialog;
    public bool codeChar;

    private void Start()
    {
        dialogDone = true;
        skipDialog = false;
    }

    public void DialogFunction(string name, string text)
    {
        LeTexte.text = "";
        Name.GetComponent<TMP_Text>().text = name;
        if (text.Length >= 210) //Large Box 210
        {
            BS.DisplayBox(3);
            Name.GetComponent<RectTransform>().anchoredPosition = new Vector2(-154.7f, 100.3f);
            Text.GetComponent<RectTransform>().anchoredPosition = new Vector2(-76.4f, 41.5f);
        }
        else if(text.Length > 93) //Medium Box
        {
            BS.DisplayBox(2);
            Name.GetComponent<RectTransform>().anchoredPosition = new Vector2(-154.7f, 27.2f);
            Text.GetComponent<RectTransform>().anchoredPosition = new Vector2(-76.4f, -29f);
        }
        else // Small Box 
        {
            BS.DisplayBox(1);
            Name.GetComponent<RectTransform>().anchoredPosition = new Vector2(-154.7f, -21.3f);
            Text.GetComponent<RectTransform>().anchoredPosition = new Vector2(-76.4f, -74.2f);
        }
        StartCoroutine(ShowText(text));
    }

    IEnumerator ShowText(string text) // Changer la couleur d'un ou plusieurs mots
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
}
