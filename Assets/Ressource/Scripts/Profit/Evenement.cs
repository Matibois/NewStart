using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evenement : MonoBehaviour
{
    #region event_text
    public string activeEvent = "Aucun �v�nement actif";
    public string activeEventDescription = "Aucun �v�nement actif";


    public const string titreSurgelePositifEvent = "P�nurie de Frais";
    public const string descriptionSurgelePositifEvent = "Les rayons de produits frais se vident, poussant les consommateurs � se tourner vers les surgel�s.";

    public const string titreSurgeleNegatifEvent = "Surgel� vs �cologie";
    public const string descriptionSurgeleNegatifEvent = "Les pr�occupations �cologiques poussent les consommateurs � �viter les produits surgel�s, jug�s moins durables.";

    public const string titreBioPositifEvent = "Abondance Saisonnale";
    public const string descriptionBioPositifEvent = "Les r�coltes sont g�n�reuses cette saison. Les �tals bio et locaux attirent les regards et les caddies.";

    public const string titreBioNegatifEvent = "Bio de Grande Surface";
    public const string descriptionBioNegatifEvent = "Les grandes surfaces lancent des gammes bio � bas prix, mettant en difficult� les petits producteurs locaux.";

    public const string titreLivraisonPositifEvent = "Confinement : Livraison � Plein R�gime";
    public const string descriptionLivraisonPositifEvent = "Avec le confinement, la demande de services de livraison � domicile explose, cr�ant de nouvelles opportunit�s.";

    public const string titreLivraisonNegatifEvent = "Essence en Hausse";
    public const string descriptionLivraisonNegatifEvent = "La hausse des prix du carburant alourdit les co�ts de livraison, for�ant les entreprises � augmenter leurs tarifs.";

    public const string titreProfParticulierPositifEvent = "Programmes Complexes";
    public const string descriptionProfParticulierPositifEvent = "Les programmes scolaires deviennent plus difficiles, les parents r�clament des cours suppl�mentaires.";

    public const string titreProfParticulierNegatifEvent = "�cole en Ligne";
    public const string descriptionProfParticulierNegatifEvent = " Les cours digitals s'installent confortablement � la maison. L'enseignement en face-�-face semble perdre du terrain.";

    public const string titreCoachSportifPositifEvent = "�v�nements Sportifs";
    public const string descriptionCoachSportifPositifEvent = "L'organisation de nombreux �v�nements sportifs ravive l'int�r�t pour les coachs et programmes d'entra�nement.";

    public const string titreCoachSportifNegatifEvent = "Fermeture des salles";
    public const string descriptionCoachSportifNegatifEvent = "Avec les restrictions sanitaires, les salles de sport ferment, limitant les possibilit�s d'entra�nement.";

    public const string titreAidePersonnePositifEvent = "Vague de Maladie";
    public const string descriptionAidePersonnePositifEvent = "L'augmentation des maladies saisonni�res cr�e une forte demande pour les services d'aide � la personne.";

    public const string titreAidePersonneNegatifEvent = "Nouvelles technologies";
    public const string descriptionAidePersonneNegatifEvent = "Les nouvelles technologies, comme les robots d'assistance, commencent � remplacer les services d'aide � la personne.";

    public const string titreCoursePositifEvent = "Tour de France";
    public const string descriptionCoursePositifEvent = "L'engouement pour le Tour de France pousse de nombreux amateurs � investir dans des v�los de course haut de gamme.";

    public const string titreCourseNegatifEvent = "V�lo en D�clin";
    public const string descriptionCourseNegatifEvent = "Un scandale dans l'industrie du v�lo de course �rode la confiance des consommateurs et affecte les ventes.";

    public const string titreVTTBMXPositifEvent = "Tournoi de BMX";
    public const string descriptionVTTBMXPositifEvent = "Les comp�titions de freestyle attirent l'attention sur le VTT et le BMX.";

    public const string titreVTTBMXNegatifEvent = "Champion � Terre";
    public const string descriptionVTTBMXNegatifEvent = "Tim�o, le champion local, se blesse gravement, suscitant des inqui�tudes autour de la s�curit� du sport.";

    public const string titreVillePositifEvent = "Transports � l'Arr�t";
    public const string descriptionVillePositifEvent = "La gr�ve des transports pousse les citadins � adopter des solutions alternatives comme les v�los en libre service.";

    public const string titreVilleNegatifEvent = "Libre-Service en Panne";
    public const string descriptionVilleNegatifEvent = "Le mat�riel en libre-service souffre de d�gradations, frustrant les utilisateurs r�guliers et r�duisant la demande.";

    public const string titreLuxePositifEvent = "D�fil� de mode";
    public const string descriptionLuxePositifEvent = "Le dernier d�fil� de mode suscite un vif int�r�t pour les marques de luxe, dynamisant les ventes.";

    public const string titreLuxeNegatifEvent = "Luxe Entach�";
    public const string descriptionLuxeNegatifEvent = "Un scandale �clate dans l'industrie du luxe, ternissant l'image des grandes marques et freinant les achats.";

    public const string titreSportPositifEvent = "Comp�tition de sport";
    public const string descriptionSportPositifEvent = "L'approche des grandes comp�titions stimule l'int�r�t pour les �quipements sportifs et les pr�parations physiques.";

    public const string titreSportNegatifEvent = "Canicule";
    public const string descriptionSportNegatifEvent = "La canicule rend la pratique du sport plus difficile, for�ant certains � revoir leurs activit�s en ext�rieur.";

    public const string titreQuotidiensPositifEvent = "Saison des Soldes";
    public const string descriptionQuotidiensPositifEvent = "Les soldes attirent une foule de clients, boostant les ventes dans les magasins.";

    public const string titreQuotidiensNegatifEvent = "Nouvelle Ouverture en Ville";
    public const string descriptionQuotidiensNegatifEvent = "Un nouveau magasin vient d'ouvrir ses portes � proximit�, attirant l'attention des clients locaux.";

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
