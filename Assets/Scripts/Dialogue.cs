using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public float delay = 0.1f;
    public TMP_Text LeTexte;
    public string fullText;
    private string currentText = "";
    void Start()
    {
        StartCoroutine(ShowText());

    }

    private void Update()
    {

    }

    IEnumerator ShowText()
    {
        Debug.Log("ShowText");
        for (int i = 0; i <= fullText.Length; i++)
        {
           
            Debug.Log(fullText);
            LeTexte.text = fullText.Substring(0, i);

            yield return new WaitForSeconds(delay);
        }
    }
}
