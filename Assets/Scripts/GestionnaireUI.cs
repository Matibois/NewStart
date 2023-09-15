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

    [SerializeField] TMP_InputField NameEntry;
    [SerializeField] TMP_InputField EntrepriseNameEntry;
    [SerializeField] TMP_Text NameText;
    [SerializeField] TMP_Text EntrepriseNameText;
    [SerializeField] TMP_Text PosText;
    [SerializeField] TMP_Text PlaceText;
    [SerializeField] TMP_Text JobText;
    [SerializeField] TMP_Text SousMetier1Text;
    [SerializeField] TMP_Text SousMetier2Text;
    [SerializeField] TMP_Text SousMetier3Text;

    [SerializeField] private Entreprise entreprise;
    public string UserName;
    public string EntrepriseName;
    public shop job;
    public int Money;
    public int TypeChoice;
    public place lieu;

    public int intSurgele;
    public int intLivraison;
    public int intBio;

    public int intCourse;
    public int intVTT;
    public int intVille;

    public int intAidePerso;
    public int intProfParticulier;
    public int intCoachSport;

    public int intLuxe;
    public int intSport;
    public int intQuotidiens;

    public void RefreshData()
    {
        GetDataToRefresh();
        GetIntMetier();

        RefreshName();
        RefreshPlace();
        RefreshJob();
    }

    private void RefreshName()
    {
        NameText.text = UserName;
    }

    private void GetDataToRefresh()
    {
        entreprise = FindObjectOfType<Entreprise>();

        UserName = entreprise.GetUserName();
        EntrepriseName = entreprise.GetEntrepriseName();
        Money = entreprise.GetMoney();
        job = entreprise.GetShop();
        lieu = entreprise.GetPlace();
    }

    private void GetIntMetier()
    {
        intSurgele = entreprise.GetSurgele();
        intLivraison = entreprise.GetLivraison();
        intBio = entreprise.GetBio();
        intCourse = entreprise.GetCourses();
        intVTT = entreprise.GetVTT();
        intVille = entreprise.GetVille();
        intAidePerso = entreprise.GetAidePerso();
        intProfParticulier = entreprise.GetProfParticulier();
        intCoachSport = entreprise.GetCoachSport();
        intLuxe = entreprise.GetLuxe();
        intSport = entreprise.GetSport();
        intQuotidiens = entreprise.GetQuotidiens();

    }

    public void RefreshPlace()
    {
        switch (lieu)
        {
            case place.WhiteMontain:
                PlaceText.text = "White Montain";
                break;

            case place.PalmCoconut:
                PlaceText.text = "Palm Coconut";
                break;

            case place.UrbanCity:
                PlaceText.text = "Urban City";
                break;

            case place.FenzyFarm:
                PlaceText.text = "Fenzy Farm";
                break;
        }
    }
    public void RefreshJob()
    {
        switch (job)
        {
            case shop.Aliment:
                JobText.text = job.ToString();
                break;
            case shop.Velo:
                JobText.text = job.ToString();
                break;
            case shop.Service:
                JobText.text = job.ToString();
                break;
            case shop.Vetement:
                JobText.text = job.ToString();
                break;
        }
    }

    public void ErasePlace() { PlaceText.text = string.Empty; }
    public void EraseJob() { JobText.text = string.Empty; }
}
