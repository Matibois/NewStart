using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public float delay = 0.05f;
    public TMP_Text LeTexte;
    public string fullText;

    public BoxSize BS;
    public GameObject Name;
    public GameObject Text;

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
        if(text.Length > 93 && text.Length < 210) //Medium Box
        {
            BS.DisplayBox(2);
            Name.GetComponent<RectTransform>().anchoredPosition = new Vector2(-154.7f, 27.2f);
            Text.GetComponent<RectTransform>().anchoredPosition = new Vector2(-76.4f, -29f);
        }
        else if (text.Length >= 210) //Large Box 210
        {
            BS.DisplayBox(3);
            Name.GetComponent<RectTransform>().anchoredPosition = new Vector2(-154.7f, 100.3f);
            Text.GetComponent<RectTransform>().anchoredPosition = new Vector2(-76.4f, 41.5f);
        }
        else // Small Box 
        {
            BS.DisplayBox(1);
            Name.GetComponent<RectTransform>().anchoredPosition = new Vector2(-154.7f, -21.3f);
            Text.GetComponent<RectTransform>().anchoredPosition = new Vector2(-76.4f, -74.2f);
        }
        StartCoroutine(ShowText(text));
    }

    IEnumerator ShowText(string text) //Changer la couleur d'un ou plusieurs mots
    {
        dialogDone = false;
        codeChar = false;
        
        for (int i = 0; i <= text.Length; i++)
        {
            LeTexte.text = text.Substring(0, i);
            
            /* C'est cass�, pas toucher.
            Debug.Log(text.Length);
            
            if (text[i+1] == '<' && LeTexte.text.Length < text.Length)
            {
                codeChar = true;
            } 
            else if (text[i+1] == '>' && LeTexte.text.Length < text.Length)
            {
                codeChar = false;
            }
            */
            
            if (skipDialog == false && codeChar == false)
            {
                yield return new WaitForSeconds(delay);
            }
            
        }
        dialogDone = true;
        skipDialog = false;
    }
}