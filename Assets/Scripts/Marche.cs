using UnityEngine;

[System.Serializable]
public class Marche
{
    [SerializeField] public int Habitants;
    [SerializeField] public int RPH;
    [SerializeField] public int AgeMoyen;

    [SerializeField] public int AlimentNBR;
    [SerializeField] public int AlimentSurgele;
    [SerializeField] public int AlimentBio;
    [SerializeField] public int AlimentLivraison;

    [SerializeField] public int VeloNBR;
    [SerializeField] public int VeloCourse;
    [SerializeField] public int VeloVTT;
    [SerializeField] public int VeloVille;

    [SerializeField] public int ServiceNBR;
    [SerializeField] public int ServicesCoachSport;
    [SerializeField] public int ServiceProfParticulier;
    [SerializeField] public int ServiceAidePerso;

    [SerializeField] public int VetementNBR;
    [SerializeField] public int VetementLuxe;
    [SerializeField] public int VetementSport;
    [SerializeField] public int VetementQuotidiens;

    public Marche()
    {
        InitializeValues();
        CreateEntreprise();
    }

    private void InitializeValues()
    {
        Habitants = SetHabitant();
        RPH = AverageMoney();
        AgeMoyen = AverageAge();
    }

    private int SetHabitant()
    {
        return new System.Random().Next(1, 4);
    }

    private int AverageAge()
    {
        return new System.Random().Next(1, 4);
    }

    private int AverageMoney()
    {
        return new System.Random().Next(1, 4);
    }

    public void CreateEntreprise()
    {
        System.Random random = new System.Random();

        AlimentSurgele = random.Next(1, 4);
        AlimentBio = random.Next(1, 4);
        AlimentLivraison = random.Next(1, 4);
        AlimentNBR = AlimentSurgele + AlimentLivraison + AlimentBio;

        VeloCourse = random.Next(1, 4);
        VeloVTT = random.Next(1, 4);
        VeloVille = random.Next(1, 4);
        VeloNBR = VeloCourse + VeloVTT + VeloVille;

        ServicesCoachSport = random.Next(1, 4);
        ServiceProfParticulier = random.Next(1, 4);
        ServiceAidePerso = random.Next(1, 4);
        ServiceNBR = ServicesCoachSport + ServiceProfParticulier + ServiceAidePerso;

        VetementLuxe = random.Next(1, 4);
        VetementSport = random.Next(1, 4);
        VetementQuotidiens = random.Next(1, 4);
        VetementNBR = VetementLuxe + VetementSport + VetementQuotidiens;
    }
}