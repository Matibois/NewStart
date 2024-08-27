using System.IO;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static Entreprise;
using UnityEngine.Rendering.Universal;
using System;

public class GestionnaireUI : MonoBehaviour
{
    [SerializeField] TMP_Text NameText;
    [SerializeField] TMP_Text EntrepriseNameText;
    [SerializeField] TMP_Text PlaceText;
    [SerializeField] TMP_Text JobText;

    [SerializeField] TMP_Text SousMetier1Name;
    [SerializeField] TMP_Text SousMetier2Name;
    [SerializeField] TMP_Text SousMetier3Name;

    [SerializeField] TMP_Text SousMetierPoints;
    [SerializeField] TMP_Text SousMetier1Points;
    [SerializeField] TMP_Text SousMetier2Points;
    [SerializeField] TMP_Text SousMetier3Points;

    [SerializeField] TMP_Text pubPointText;
    [SerializeField] TMP_Text newsLetterPointText;
    [SerializeField] TMP_Text boiteAuLettrePointText;

    [SerializeField] TMP_Text fakebookPointText;
    [SerializeField] TMP_Text yourTubePointText;
    [SerializeField] TMP_Text amstramgramPointText;

    [SerializeField] TMP_Text magTelePointText;
    [SerializeField] TMP_Text libertePointText;
    [SerializeField] TMP_Text svjPointText;


    [SerializeField] private Entreprise entreprise;
    public Shop job;
    public Place lieu;

    public void RefreshData()
    {
        RefreshPlace();
        RefreshJob();
    }

    public void Named(string name)
    {
        NameText.text = name;
    }

    public void EntrepriseNamed(string name)
    {
        EntrepriseNameText.text = name;
    }

    public void RefreshPlace()
    {
        lieu = entreprise.GetPlace();

        switch (lieu)
        {
            case Place.WhiteMontain:
                PlaceText.text = "White Montain";
                break;

            case Place.PalmCoconut:
                PlaceText.text = "Palm Coconut";
                break;

            case Place.UrbanCity:
                PlaceText.text = "Urban City";
                break;

            case Place.FenzyFarm:
                PlaceText.text = "Fenzy Farm";
                break;
        }
    }
    public void RefreshJob()
    {
        job = entreprise.GetShop();

        switch (job)
        {
            case Shop.Aliment:
                JobText.text = "Magasin alimentaire";
                SousMetier1Name.text = "Surgele";
                SousMetier2Name.text = "Bio";
                SousMetier3Name.text = "Livraison";
                break;
            case Shop.Velo:
                JobText.text = "Magasin de Velo";
                SousMetier1Name.text = "VTT";
                SousMetier2Name.text = "Course";
                SousMetier3Name.text = "Ville";
                break;
            case Shop.Service:
                JobText.text = "Service Personnelle";
                SousMetier1Name.text = "Aide Personnelle";
                SousMetier2Name.text = "Coach Sportif";
                SousMetier3Name.text = "Prof Particulier";
                break;
            case Shop.Vetement:
                JobText.text = job.ToString();
                SousMetier1Name.text = "Luxe";
                SousMetier2Name.text = "Sport";
                SousMetier3Name.text = "Quotidiens";
                break;
        }
    }

    public void RefreshSousMetierPoints(int points, int points1, int points2, int points3)
    {
        SousMetierPoints.text = points.ToString();
        SousMetier1Points.text = points1.ToString();
        SousMetier2Points.text = points2.ToString();
        SousMetier3Points.text = points3.ToString();
    }

    public void ErasePlace() { PlaceText.text = string.Empty; }
    public void EraseJob() { JobText.text = string.Empty; }
}
