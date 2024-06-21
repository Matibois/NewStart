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
        for (int i = 0; i == fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            LeTexte.text = currentText;

            yield return new WaitForSeconds(0);
        }
    }
}
