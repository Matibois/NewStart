using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tuto : MonoBehaviour
{
    [SerializeField] GameObject tutoGO;
    [SerializeField] TMP_Text tutoTMP;

    string[] tutoTexts = new string[]
    {
        "Appuyez sur ↑ pour avancer",
        "Vouvez aussi utiliser la touche W sur un clavier QWERTY Z sur un clavier AZERTY",
        "Appuyez sur ← pour aller à gauche",
        "Vouvez aussi utiliser la touche A sur un clavier QWERTY ou Q sur un clavier AZERTY",
        "Appuyez sur ↓ pour reculer",
        "Vouvez aussi utiliser la touche S",
        "Appuyez sur → pour aller à droite",
        "Vouvez aussi utiliser la touche D",
        "Vous pouvez intéragir avec des personnes ou des objets",
        "Lorsque ceux-ci brillent, appuyez sur F pour intéragir",
        "Si vous avez un trou de mémoire, pas de panique !",
        "Les contrôles sont accessibles dans les parametres en haut à gauche de l'écran"

    };

    private void Start()
    {
        
    }

    private void MoveTuto()
    {

    }
}
