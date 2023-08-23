using UnityEngine;

[System.Serializable]
public class Marche
{
    [SerializeField] public int Habitants;
    [SerializeField] public int RPH;
    [SerializeField] public int AgeMoyen;

    [SerializeField] public int RestauNBR;
    [SerializeField] public int RestauLuxe;
    [SerializeField] public int RestauBio;
    [SerializeField] public int RestauFastFood;

    [SerializeField] public int VeloNBR;
    [SerializeField] public int VeloCourse;
    [SerializeField] public int VeloVTT;
    [SerializeField] public int VeloElectric;

    [SerializeField] public int CoachNBR;
    [SerializeField] public int CoachSport;
    [SerializeField] public int CoachEntreprise;
    [SerializeField] public int CoachSelfDeveloppement;

    [SerializeField] public int VetementNBR;
    [SerializeField] public int VetementLuxe;
    [SerializeField] public int VetementSport;
    [SerializeField] public int VetementTechWear;

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

        RestauLuxe = random.Next(1, 4);
        RestauBio = random.Next(1, 4);
        RestauFastFood = random.Next(1, 4);
        RestauNBR = RestauLuxe + RestauFastFood + RestauBio;

        VeloCourse = random.Next(1, 4);
        VeloVTT = random.Next(1, 4);
        VeloElectric = random.Next(1, 4);
        VeloNBR = VeloCourse + VeloVTT + VeloElectric;

        CoachSport = random.Next(1, 4);
        CoachEntreprise = random.Next(1, 4);
        CoachSelfDeveloppement = random.Next(1, 4);
        CoachNBR = CoachSport + CoachEntreprise + CoachSelfDeveloppement;

        VetementLuxe = random.Next(1, 4);
        VetementSport = random.Next(1, 4);
        VetementTechWear = random.Next(1, 4);
        VetementNBR = VetementLuxe + VetementSport + VetementTechWear;
    }
}