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
    public Dictionary<int, Dictionary<string, string>> kiosk;
    public Dictionary<int, Dictionary<string, string>> commercant;

    public Dictionary<int, Dictionary<string, string>> kioskUtile;
    public Dictionary<int, Dictionary<string, string>> kioskInutile1;
    public Dictionary<int, Dictionary<string, string>> kioskInutile2;

    public Dictionary<int, Dictionary<string, string>> mairieUtile;
    public Dictionary<int, Dictionary<string, string>> mairieInutile1;
    public Dictionary<int, Dictionary<string, string>> mairieInutile2;

    public Dictionary<int, Dictionary<string, string>> dejaNote;




    public void InitIntro()
    {
        intro = new Dictionary<int, Dictionary<string, string>>
        {
            //Introduction
            { 0, new Dictionary<string, string> { { "speaker", "???" }, { "dialogue", "Bonjour ! " } } },
            { 1, new Dictionary<string, string> { { "speaker", "???" }, { "dialogue", "Je vois que vous êtes un jeune entrepreneur ambitieux qui cherche à lancer l'entreprise de ses rêves." } } },
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
            { 17, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Ne vous inquiètez pas, je serai à vos côtés tout au long du processus! " } } },
            { 18, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Pour commencer, et si on sortait ? " } } },
            { 19, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } }, // Fin de l'intro
            { 20, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Oooh ! Alors tu habites à <color=yellow>Fenzy Farm</color>." } } }, // Fenzy Farm est visible
            { 21, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Un petit village, c'est parfait pour faire notre étude de marché." } } },
            { 22, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Il y a plusieurs manières de récupérer des informations." } } },
            { 23, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Tu peux aller au <color=yellow>kiosque</color>, à la <color=yellow>mairie</color> ou parler avec le <color=yellow>commerçant</color> du coin." } } },
            { 24, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Et tiens ! Je pense que ça te seras utile." } } },
            { 25, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } }, // Le joueur reçoit le carnet 
            { 26, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Voici ton <color=yellow>carnet de notes</color> !" } } }, // Le joueur ouvre le carnet
            { 27, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Ici tu es sur la <color=yellow>carte</color>. En cliquant sur les cartes postales tu peux te rendre vers diff�rentes destinations." } } },
            { 28, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Appuie sur l'intercalaire orange, sur la droite." } } },
            { 29, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Dans ce carnet tu peux prendre en note toutes les informations utiles à notre recherche." } } }, // Le joueur appuie sur l'intercalaire Orange
            { 30, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Il va donc falloir que tu penses à <color=yellow>prendre en note</color> ce que l'on te dit ou ce que tu lis." } } },
            { 31, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Nous sommes à Fenzy Farm, donc tu peux retrouver les informations que tu récupèreras ici." } } },
            { 32, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Je le remplirai également avec des commentaires et des données que je vais aller récupèrer de mon côté." } } },
            { 33, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Tu trouveras également un <color=green>glossaire</color>, accessible avec le marque-page vert." } } },
            { 34, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Et enfin, avec le marque page rouge, j'ai repertorié tes <color=red>objectifs</color>." } } },
            { 35, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Si jamais tu ne sais plus quoi faire, ou que tu veux savoir où tu en es, n'hésite pas à consulter ces pages." } } },
            { 36, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } }, // Le joueur referme son carnet
            { 37, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Je vais maintenant commencer ô faire mes sondages en ligne." } } },
            { 38, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "De ton côté, fais le tour de la ville et récupère un maximum d'informations." } } },
            { 39, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Bonne recherche, partenaire !" } } },
            { 40, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } }, // Le joueur commence sa recherche

            //Kiosk Tuto
            { 50, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Ici, c'est le <color=yellow>kiosque</color>." } } },
            { 51, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Comme tu peux le voir, il y a plein d'articles et d'autres annonces diverses affichées." } } },
            { 52, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Pour <color=yellow>prendre en note</color> une affiche dans ton carnet, il te suffit de <color=yellow>cliquer dessus</color>." } } },
            { 53, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Mais fais attention ! Toutes les informations ne sont pas utiles pour notre étude de marché." } } },
            { 54, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Sélectionne seulement celles qui te semblent utiles." } } },
            { 55, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } }, 

            //Note utile
            { 59, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Je consulte le fichier..." } } },
            { 60, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Oui, cette information peut servir !" } } },
            { 61, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Elle est notée dans ton <color=yellow>carnet</color>." } } },
            { 62, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } },
            { 63, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Cette information est déjà dans ton carnet." } } },
            { 64, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } },
            
            //Note inutile
            { 65, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Hmmm... Je ne vois pas en quoi cette information nous aiderait." } } },
            { 66, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } },
            { 67, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Cette information n'est pas utile pour notre étude de marché." } } },
            { 68, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } },

            //Mairie Tuto
            { 70, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Te voilà sur <color=yellow>l'ordinateur de la mairie</color>." } } },
            { 71, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Ici tu peux consulter à volonté des documents pour te renseigner sur la ville et ses habitants." } } },
            { 72, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Hmm. Je vois qu'il y a beaucoup de tableaux et de données." } } },
            { 73, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Si tu veux prendre en note un document, <color=yellow>clique dessus</color> et je le consulterai en d�tail." } } },
            { 74, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Si les informations que tu m'envoies sont utiles nous les ajouteront au carnet." } } },
            { 75, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Sélectionne seulement celles qui te semblent utiles." } } },
            { 76, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } },

            //Note inutile
            { 78, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Je consulte le fichier..." } } },
            { 79, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Hmmm... Je ne vois pas en quoi ces informations nous aideraient." } } },
            { 80, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } },
            { 81, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Je consulte le fichier..." } } },
            { 82, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Cette information n'est pas utile pour notre �tude de march�." } } },
            { 83, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } },
        };
    }

    public void InitMairie()
    {
        mairie = new Dictionary<int, Dictionary<string, string>>
        {
            { 0, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Te voilà sur <color=yellow>l'ordinateur de la mairie</color>." } } },
            { 1, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Ici tu peux consulter à volonté des documents pour te renseigner sur la ville et ses habitants." } } },
            { 2, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Hmm. Je vois qu'il y a beaucoup de tableaux et de données." } } },
            { 3, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Si tu veux prendre en note un document, <color=yellow>clique dessus</color> et je le consulterai en détail." } } },
            { 4, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Si les informations que tu m'envoies sont utiles nous les ajouteront au carnet." } } },
            { 5, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Sélectionne seulement celles qui te semblent utiles." } } },
            { 6, new Dictionary<string, string> { { "speaker", "" }, { "dialogue", "" } } },
        };
    }

    public void InitMairieUtile()
    {
        kioskUtile = new Dictionary<int, Dictionary<string, string>>
        {
            { 59, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Je consulte le fichier..." } } },
            { 60, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Oui, cette information peut servir !" } } },
            { 61, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Elle est not�e dans ton <color=yellow>carnet</color>." } } },
            
            //{ 63, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Cette information est d�j� dans ton carnet." } } },
            
        };
    }

    public void InitMairieInutile1()
    {
        kioskInutile1 = new Dictionary<int, Dictionary<string, string>>
        {

            { 0, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Je consulte le fichier..." } } },
            { 1, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Cette information n'est pas utile pour notre �tude de march�." } } },
            
            //{ 2, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Je consulte le fichier..." } } },
            //{ 3, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Hmmm... Je ne vois pas en quoi ces informations nous aideraient." } } },
        };
    }
    public void InitMairieInutile2()
    {
        kioskInutile2 = new Dictionary<int, Dictionary<string, string>>
        {
            { 0, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Je consulte le fichier..." } } },
            { 1, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Hmmm... Je ne vois pas en quoi ces informations nous aideraient." } } },
        };
    }



    public void InitKiosque()
    {
        kiosk = new Dictionary<int, Dictionary<string, string>>
        {
            { 0, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Ici, c'est le <color=yellow>kiosque</color>." } } },
            { 1, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Comme tu peux le voir, il y a plein d'articles et d'autres annonces diverses affich�es." } } },
            { 2, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Pour <color=yellow>prendre en note</color> une affiche dans ton carnet, il te suffit de <color=yellow>cliquer dessus</color>." } } },
            { 3, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Mais fais attention ! Toutes les informations ne sont pas utiles pour notre �tude de march�." } } },
            { 4, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "S�lectionne seulement celles qui te semblent utiles." } } },
        };
    }
    public void InitKioskUtile()
    {
        kioskUtile = new Dictionary<int, Dictionary<string, string>>
        {
            { 0, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Bite..." } } },
        };
    }

    public void InitKioskInutile1()
    {
        kioskInutile1 = new Dictionary<int, Dictionary<string, string>>
        {
            { 0, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Hmmm... Je ne vois pas en quoi cette information nous aiderait." } } },
        };
    }
    public void InitKioskInutile2()
    {
        kioskInutile1 = new Dictionary<int, Dictionary<string, string>>
        {
            { 0, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Cette information n'est pas utile pour notre �tude de march�." } } },
        };
    }


    public void DejaNote()
    {
        dejaNote = new Dictionary<int, Dictionary<string, string>>
        {
            { 63, new Dictionary<string, string> { { "speaker", "Bebot" }, { "dialogue", "Cette information est d�j� dans ton carnet." } } },
        };
    }
}
