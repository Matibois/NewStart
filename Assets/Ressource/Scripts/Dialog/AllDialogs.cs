using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class AllDialogs 
{

    public Dictionary<int, Dictionary<string, string>> dialogues;


    public void InitDictionnary()
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
            { 14, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "On appelle �a, <color=yellow>l'�tude de march� !</color> " } } },
            { 15, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Cette �tude � pour objectif d'analyser l'offre et la demande sur notre march� afin de mettre en place une strat�gie marketing. " } } },
            { 16, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Les informations que nous allons r�colter vont nous permettre d'orienter nos choix commerciaux. " } } },
            { 17, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Ne vous inqui�tez pas, je serai � vos c�t�s tout au long du processus! " } } },
            { 18, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Pour commencer, et si on sortait ? " } } },
            { 19, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } }, // Fin de l'intro
            { 20, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Oooh ! Alors tu habites � <color=yellow>Fenzy Farm</color>." } } }, // Fenzy Farm est visible
            { 21, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Un petit village, c'est parfait pour faire notre �tude de march�." } } },
            { 22, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Il y a plusieurs mani�res de r�cup�rer des informations." } } },
            { 23, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Tu peux aller au kiosque, � la mairie ou parler avec le commer�ant du coin." } } },
            { 24, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Et tiens ! Je pense que �a te seras utile." } } },
            { 25, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } }, // Le joueur re�oit le carnet 
            { 26, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Dans ce carnet tu peux prendre en note toutes les informations utiles � notre recherche." } } }, //Le joueur ouvre le carnet
            { 27, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Je le remplirai �galement avec des commentaires et des donn�es que je vais aller r�cup�rer de mon c�t�." } } },
            { 28, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Tu trouveras �galement un glossaire  dans les derni�res pages" } } },
            { 29, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Pendant que je commence mes sondages en ligne, fais le tour de la ville et r�cup�re un maximum d'informations." } } },
        };
    }

}
