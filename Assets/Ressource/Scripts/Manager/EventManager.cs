using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Entreprise;

public class EventManager : MonoBehaviour
{
    [SerializeField] Entreprise entreprise;
    [SerializeField] Developpement developpement;


    private Evenement evenement = new();

    private void Start()
    {

    }

    private void GetPositifEvent()
    {
        int sousmetier;
        switch (entreprise.GetShop())
        {
            case Shop.Aliment:
                sousmetier = CompareInvestissement(entreprise.GetSurgele(), entreprise.GetBio(), entreprise.GetLivraison(), false);
                evenement.GetFoodPositive(sousmetier);
                break;
            case Shop.Velo:
                sousmetier = CompareInvestissement(entreprise.GetVTT(), entreprise.GetCourses(), entreprise.GetVille(), false);
                evenement.GetVeloPositive(sousmetier);
                break;
            case Shop.Service:
                sousmetier = CompareInvestissement(entreprise.GetAidePerso(), entreprise.GetCoachSport(), entreprise.GetProfParticulier(), false);
                evenement.GetServicePositive(sousmetier);
                break;
            case Shop.Vetement:
                sousmetier = CompareInvestissement(entreprise.GetLuxe(), entreprise.GetSport(), entreprise.GetQuotidiens(), false);
                evenement.GetVetementPositive(sousmetier);

                break;

        }
    }

    private int CompareInvestissement(int a, int b, int c, bool biggest)
    { // retourne le sous métier dans lequel il y a le plus / le moins d'investissement
        int grand = a;
        int petit = a;

        if (b > grand) grand = b;
        if (c > grand) grand = c;


        if (b < petit) petit = b;
        if (c < petit) petit = c;


        if (biggest)
        {
            if (grand == a) return 0;
            if (grand == b) return 1;
            return 2;
        }

        if (petit == a) return 0;
        if (petit == b) return 1;
        return 2;


    }

    private void EventPositifVetement(int sousmetier)
    {
        int rapport = 0;
        switch (sousmetier)
        {
            case 0:
                switch (entreprise.GetLuxe())
                {
                    case 0:
                        rapport = -5;
                        break;
                    case 1:
                        rapport = 3;
                        break;
                    case 2:
                        rapport = 7;
                        break;
                    case 3:
                        rapport = 15;
                        break;
                }
                break;

            case 1:
                switch (entreprise.GetSport())
                {
                    case 0:
                        rapport = -5;
                        break;
                    case 1:
                        rapport = 3;
                        break;
                    case 2:
                        rapport = 7;
                        break;
                    case 3:
                        rapport = 15;
                        break;
                }
                break;

            case 2:
                switch (entreprise.GetQuotidiens())
                {
                    case 0:
                        rapport = -5;
                        break;
                    case 1:
                        rapport = 3;
                        break;
                    case 2:
                        rapport = 7;
                        break;
                    case 3:
                        rapport = 15;
                        break;
                }
                break;
        }
        developpement.EventImpact(rapport);
    }

}
