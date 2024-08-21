using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evenement : MonoBehaviour
{
    #region event_text
    public string activeEvent = "Aucun événement actif";
    public string activeEventDescription = "Aucun événement actif";


    public const string titreSurgelePositifEvent = "Pénurie de Frais";
    public const string descriptionSurgelePositifEvent = "Les rayons de produits frais se vident, poussant les consommateurs à se tourner vers les surgelés.";

    public const string titreSurgeleNegatifEvent = "Surgelé vs Écologie";
    public const string descriptionSurgeleNegatifEvent = "Les préoccupations écologiques poussent les consommateurs à éviter les produits surgelés, jugés moins durables.";

    public const string titreBioPositifEvent = "Abondance Saisonnale";
    public const string descriptionBioPositifEvent = "Les récoltes sont généreuses cette saison. Les étals bio et locaux attirent les regards et les caddies.";

    public const string titreBioNegatifEvent = "Bio de Grande Surface";
    public const string descriptionBioNegatifEvent = "Les grandes surfaces lancent des gammes bio à bas prix, mettant en difficulté les petits producteurs locaux.";

    public const string titreLivraisonPositifEvent = "Confinement : Livraison à Plein Régime";
    public const string descriptionLivraisonPositifEvent = "Avec le confinement, la demande de services de livraison à domicile explose, créant de nouvelles opportunités.";

    public const string titreLivraisonNegatifEvent = "Essence en Hausse";
    public const string descriptionLivraisonNegatifEvent = "La hausse des prix du carburant alourdit les coûts de livraison, forçant les entreprises à augmenter leurs tarifs.";

    public const string titreProfParticulierPositifEvent = "Programmes Complexes";
    public const string descriptionProfParticulierPositifEvent = "Les programmes scolaires deviennent plus difficiles, les parents réclament des cours supplémentaires.";

    public const string titreProfParticulierNegatifEvent = "École en Ligne";
    public const string descriptionProfParticulierNegatifEvent = " Les cours digitals s'installent confortablement à la maison. L'enseignement en face-à-face semble perdre du terrain.";

    public const string titreCoachSportifPositifEvent = "Événements Sportifs";
    public const string descriptionCoachSportifPositifEvent = "L'organisation de nombreux événements sportifs ravive l'intérêt pour les coachs et programmes d'entraînement.";

    public const string titreCoachSportifNegatifEvent = "Fermeture des salles";
    public const string descriptionCoachSportifNegatifEvent = "Avec les restrictions sanitaires, les salles de sport ferment, limitant les possibilités d'entraînement.";

    public const string titreAidePersonnePositifEvent = "Vague de Maladie";
    public const string descriptionAidePersonnePositifEvent = "L'augmentation des maladies saisonnières crée une forte demande pour les services d'aide à la personne.";

    public const string titreAidePersonneNegatifEvent = "Nouvelles technologies";
    public const string descriptionAidePersonneNegatifEvent = "Les nouvelles technologies, comme les robots d'assistance, commencent à remplacer les services d'aide à la personne.";

    public const string titreCoursePositifEvent = "Tour de France";
    public const string descriptionCoursePositifEvent = "L'engouement pour le Tour de France pousse de nombreux amateurs à investir dans des vélos de course haut de gamme.";

    public const string titreCourseNegatifEvent = "Vélo en Déclin";
    public const string descriptionCourseNegatifEvent = "Un scandale dans l'industrie du vélo de course érode la confiance des consommateurs et affecte les ventes.";

    public const string titreVTTBMXPositifEvent = "Tournoi de BMX";
    public const string descriptionVTTBMXPositifEvent = "Les compétitions de freestyle attirent l'attention sur le VTT et le BMX.";

    public const string titreVTTBMXNegatifEvent = "Champion à Terre";
    public const string descriptionVTTBMXNegatifEvent = "Timéo, le champion local, se blesse gravement, suscitant des inquiétudes autour de la sécurité du sport.";

    public const string titreVillePositifEvent = "Transports à l'Arrêt";
    public const string descriptionVillePositifEvent = "La grève des transports pousse les citadins à adopter des solutions alternatives comme les vélos en libre service.";

    public const string titreVilleNegatifEvent = "Libre-Service en Panne";
    public const string descriptionVilleNegatifEvent = "Le matériel en libre-service souffre de dégradations, frustrant les utilisateurs réguliers et réduisant la demande.";

    public const string titreLuxePositifEvent = "Défilé de mode";
    public const string descriptionLuxePositifEvent = "Le dernier défilé de mode suscite un vif intérêt pour les marques de luxe, dynamisant les ventes.";

    public const string titreLuxeNegatifEvent = "Luxe Entaché";
    public const string descriptionLuxeNegatifEvent = "Un scandale éclate dans l'industrie du luxe, ternissant l'image des grandes marques et freinant les achats.";

    public const string titreSportPositifEvent = "Compétition de sport";
    public const string descriptionSportPositifEvent = "L'approche des grandes compétitions stimule l'intérêt pour les équipements sportifs et les préparations physiques.";

    public const string titreSportNegatifEvent = "Canicule";
    public const string descriptionSportNegatifEvent = "La canicule rend la pratique du sport plus difficile, forçant certains à revoir leurs activités en extérieur.";

    public const string titreQuotidiensPositifEvent = "Saison des Soldes";
    public const string descriptionQuotidiensPositifEvent = "Les soldes attirent une foule de clients, boostant les ventes dans les magasins.";

    public const string titreQuotidiensNegatifEvent = "Nouvelle Ouverture en Ville";
    public const string descriptionQuotidiensNegatifEvent = "Un nouveau magasin vient d'ouvrir ses portes à proximité, attirant l'attention des clients locaux.";

    #endregion

    private int RandomNumber()
    {
        return Random.Range(0,3);
    }

    public void GetFoodPositive()
    {
        int value = RandomNumber();
        switch (value)
        {
            case 0:
                activeEvent = titreSurgelePositifEvent;
                activeEventDescription = descriptionSurgelePositifEvent;
                break;
            case 1:
                activeEvent = titreBioPositifEvent;
                activeEventDescription = descriptionBioPositifEvent;
                break;
            case 2:
                activeEvent = titreLivraisonPositifEvent;
                activeEventDescription = descriptionLivraisonPositifEvent;
                break;
        }
    }
    public void GetFoodNegative()
    {
        int value = RandomNumber();
        switch (value)
        {
            case 0:
                activeEvent = titreSurgeleNegatifEvent;
                activeEventDescription = descriptionSurgeleNegatifEvent;
                break;
            case 1:
                activeEvent = titreBioNegatifEvent;
                activeEventDescription = descriptionBioNegatifEvent;
                break;
            case 2:
                activeEvent = titreLivraisonNegatifEvent;
                activeEventDescription = descriptionLivraisonNegatifEvent;
                break;
        }
    }


    public void GetServicePositive()
    {
        int value = Random.Range(0, 3);
        switch (value)
        {
            case 0:
                activeEvent = titreProfParticulierPositifEvent;
                activeEventDescription = descriptionProfParticulierPositifEvent;
                break;
            case 1:
                activeEvent = titreCoachSportifPositifEvent;
                activeEventDescription = descriptionCoachSportifPositifEvent;
                break;
            case 2:
                activeEvent = titreAidePersonnePositifEvent;
                activeEventDescription = descriptionAidePersonnePositifEvent;
                break;
        }
    }
    public void GetServiceNegative()
    {
        int value = Random.Range(0, 3);
        switch (value)
        {
            case 0:
                activeEvent = titreProfParticulierNegatifEvent;
                activeEventDescription = descriptionProfParticulierNegatifEvent;
                break;
            case 1:
                activeEvent = titreCoachSportifNegatifEvent;
                activeEventDescription = descriptionCoachSportifNegatifEvent;
                break;
            case 2:
                activeEvent = titreAidePersonneNegatifEvent;
                activeEventDescription = descriptionAidePersonneNegatifEvent;
                break;
        }
    }
    public void GetVeloPositive()
    {
        int value = RandomNumber();
        switch (value)
        {
            case 0:
                activeEvent = titreCoursePositifEvent;
                activeEventDescription = descriptionCoursePositifEvent;
                break;
            case 1:
                activeEvent = titreVTTBMXPositifEvent;
                activeEventDescription = descriptionVTTBMXPositifEvent;
                break;
            case 2:
                activeEvent = titreSportPositifEvent;
                activeEventDescription = descriptionSportPositifEvent;
                break;
        }
    }
    public void GetVeloNegative()
    {
        int value = RandomNumber();
        switch (value)
        {
            case 0:
                activeEvent = titreCourseNegatifEvent;
                activeEventDescription = descriptionCourseNegatifEvent;
                break;
            case 1:
                activeEvent = titreVTTBMXNegatifEvent;
                activeEventDescription = descriptionVTTBMXNegatifEvent;
                break;
            case 2:
                activeEvent = titreSportNegatifEvent;
                activeEventDescription = descriptionSportNegatifEvent;
                break;
        }
    }

    public void GetVetementPositive()
    {
        int value = RandomNumber();
        switch (value)
        {
            case 0:
                activeEvent = titreVillePositifEvent;
                activeEventDescription = descriptionVillePositifEvent;
                break;
            case 1:
                activeEvent = titreLuxePositifEvent;
                activeEventDescription = descriptionLuxePositifEvent;
                break;
            case 2:
                activeEvent = titreQuotidiensPositifEvent;
                activeEventDescription = descriptionQuotidiensPositifEvent;
                break;
        }
    }
    public void GetVetementNegative()
    {
        int value = RandomNumber();
        switch (value)
        {
            case 0:
                activeEvent = titreVilleNegatifEvent;
                activeEventDescription = descriptionVilleNegatifEvent;
                break;
            case 1:
                activeEvent = titreLuxeNegatifEvent;
                activeEventDescription = descriptionLuxeNegatifEvent;
                break;
            case 2:
                activeEvent = titreQuotidiensNegatifEvent;
                activeEventDescription = descriptionQuotidiensNegatifEvent;
                break;
        }
    }

}
