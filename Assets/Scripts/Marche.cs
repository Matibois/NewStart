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
        return new System.Random().Next(4000, 400001);
    }

    private int AverageAge()
    {
        return new System.Random().Next(28, 61);
    }

    private int AverageMoney()
    {
        return new System.Random().Next(23, 61);
    }

    public void CreateEntreprise()
    {
        System.Random random = new System.Random();

        RestauLuxe = random.Next(1, Habitants / 400);
        RestauBio = random.Next(1, Habitants / 400);
        RestauFastFood = random.Next(1, Habitants / 400);
        RestauNBR = RestauLuxe + RestauFastFood + RestauBio;

        VeloCourse = random.Next(1, Habitants / 400);
        VeloVTT = random.Next(1, Habitants / 400);
        VeloElectric = random.Next(1, Habitants / 400);
        VeloNBR = VeloCourse + VeloVTT + VeloElectric;

        CoachSport = random.Next(1, Habitants / 400);
        CoachEntreprise = random.Next(1, Habitants / 400);
        CoachSelfDeveloppement = random.Next(1, Habitants / 400);
        CoachNBR = CoachSport + CoachEntreprise + CoachSelfDeveloppement;

        VetementLuxe = random.Next(1, Habitants / 400);
        VetementSport = random.Next(1, Habitants / 400);
        VetementTechWear = random.Next(1, Habitants / 400);
        VetementNBR = VetementLuxe + VetementSport + VetementTechWear;
    }
}