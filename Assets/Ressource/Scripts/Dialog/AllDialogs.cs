using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class AllDialogs 
{

    public Dictionary<int, Dictionary<string, string>> intro;
    public Dictionary<int, Dictionary<string, string>> mairie;
    public Dictionary<int, Dictionary<string, string>> kiosque;
    public Dictionary<int, Dictionary<string, string>> commerçant;
    public Dictionary<int, Dictionary<string, string>> maire;


    public void InitIntro()
    {
        intro = new Dictionary<int, Dictionary<string, string>>
        {
            { 0, new Dictionary<string, string> { { "speaker", "???" }, { "dialogue", "Bonjour ! " } } },
            { 1, new Dictionary<string, string> { { "speaker", "???" }, { "dialogue", "Je vois que vous êtes un jeune entrepreneur ambitieux qui cherche à lancer l'entreprise de ses rêves. " } } },
            { 2, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Je me présente, je suis <color=yellow>Bebot.</color> " } } },
            { 3, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Je suis votre assistant personnel et ma tâche est de vous aider à accomplir cet objectif ! " } } },
            { 4, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Et d'ailleurs, quel est votre nom ? " } } },
            { 5, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", $"Enchanté " } } },
            { 6, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Je suis ravi de vous accompagner dans cette aventure. " } } },
            { 7, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Nous allons travailler ensemble afin de faire la meilleure entreprise possible ! " } } },
            { 8, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Avant toute chose, j'aimerais avoir plus d'informations sur celle ci. " } } },
            { 9, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Quelle serait l'entreprise de tes rêves ? " } } },
            { 10, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } }, // c'est là où on va mettre le nom de l'entreprise
            { 11, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Formidable ! Votre projet à du potentiel. " } } },
            { 12, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Mais avant de créer réellement votre entreprise nous allons d'abord devoir récolter un certain nombre d'informations. " } } },
            { 13, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Sur les villes environnantes, leur populations, les clients et concurrents potentiels, les tendances du moment... " } } },
            { 14, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "On appelle ça, <color=yellow>l'étude de marché !</color> " } } },
            { 15, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Cette étude à pour objectif d'analyser l'offre et la demande sur notre marché afin de mettre en place une stratégie marketing. " } } },
            { 16, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Les informations que nous allons récolter vont nous permettre d'orienter nos choix commerciaux. " } } },
            { 17, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Ne vous inquiétez pas, je serai à vos côtés tout au long du processus! " } } },
            { 18, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Pour commencer, et si on sortait ? " } } },
            { 19, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } }, // Fin de l'intro

            { 20, new Dictionary<string, string> { { "speaker", "Cube" }, { "dialogue", "Hein ? Qui me parles ?" } } },
            { 21, new Dictionary<string, string> { { "speaker", "Cube" }, { "dialogue", "Dégage blanc bec" } } },
        };
    }

    public void InitMairie()
    {
        mairie = new Dictionary<int, Dictionary<string, string>>
        {
            { 0, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "voici la mairie" } } },
            { 1, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Ici,ekufhezriuhfuiehfuehfuhefhuefhuehfhefuheufhuehfuehfuheufhuehfuehufheufhuehfuehfuhefuhe'uhfu tu peux trouver des infos sur les gens" } } },
            { 2, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "mais aussi allez te faire enculer sec" } } },
        };
    }

    public void InitMaire()
    {
        maire = new Dictionary<int, Dictionary<string, string>>
        {
            { 0, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Je suis le maire" } } },
            { 1, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "va te faire foutre" } } },
            { 2, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "sale merde" } } },
        };
    }

}
