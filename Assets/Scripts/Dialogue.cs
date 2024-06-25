using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public float delay = 0.1f;
    public TMP_Text LeTexte;
    public string fullText;
    //private string currentText = "";

    public BoxSize BS;
    public GameObject cv;
    public GameObject Name;
    public GameObject Text;


    public void DialogFunction(string text)
    {
        LeTexte.text = "";
        if(text.Length > 107) //Medium Box
        {
            BS.DisplayBox(2);
            Name.GetComponent<RectTransform>().transform.position = new Vector2(-154.7f, 27.2f);
            Text.transform.position = transform.position + new Vector3(-76.4f, -46.6f, 0f);
        }
        else if (text.Length > 210) //Large Box
        {
            BS.DisplayBox(3);
            Name.transform.position = transform.position + new Vector3(-154.7f, 100.3f, 0f);
            Text.transform.position = transform.position + new Vector3(-76.4f, -31.6f, 0f);
        }
        else // Small Box 
        {
            BS.DisplayBox(1);
            Name.transform.position = transform.position + new Vector3(-154.7f, -21.3f, 0f);
            Text.transform.position = transform.position + new Vector3(-76.4f, -74.2f, 0f);
        }
        StartCoroutine(ShowText(text));
    }

    IEnumerator ShowText(string text)
    {
        for (int i = 0; i <= text.Length; i++)
        {
            LeTexte.text = text.Substring(0, i);
            yield return new WaitForSeconds(delay);
        }
    }
}
