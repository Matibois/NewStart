using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Marche
{
    Entreprise.place Lieu;
    Entreprise.shop Shop;
    Entreprise.CoachType CoachType;
    Entreprise.RestauType RestauType;
    Entreprise.VeloType VeloType;
    Entreprise.VetementType VetementType;

    public int Habitants;
    public int RPH; //Revenus Par Habitants
    public int AgeMoyen;
    
    public int RestauNBR;
    public int RestauLuxe;
    public int RestauBio;
    public int RestauFastFood;
    
    public int VeloNBR;
    public int VeloCourse;
    public int VeloVTT;
    public int VeloElectric;
    
    public int CoachNBR;
    public int CoachSport;
    public int CoachEntreprise;
    public int CoachSelfDeveloppement;
    
    public int VetementNBR;
    public int VetementLuxe;
    public int VetementSport;
    public int VetementTechWear;

    public Marche()
    {
        int habitants = SetHabitant();
        int rph = AverageMoney();
        int AgeMoyen = AverageAge();

        CreateEntreprise();

        int restauNBR = RestauNBR;
        int restauLuxe = RestauLuxe;
        int restauBio = RestauBio;
        int restauFastFood = RestauFastFood;

        int veloNBR = VeloNBR;
        int veloCourse = VeloCourse;
        int veloVTT = VeloVTT;
        int veloElectric = VeloElectric;

        int coachNBR = CoachNBR;
        int coachSport = CoachSport;
        int coachEntreprise = CoachEntreprise;
        int coachSelfDeveloppement = CoachSelfDeveloppement;

        int vetementNBR = VetementNBR;
        int vetementLuxe = VetementLuxe;
        int vetementSport = VetementSport;
        int vetementTechWear = VetementTechWear;

    }  
    
    private void start()
    {

    }

    private int SetHabitant(){return Habitants = Random.Range(4000, 400001);} 
    private int AverageAge(){return AgeMoyen = Random.Range(28, 61);} 
    private int AverageMoney(){return RPH = Random.Range(23, 61);} 
    public void CreateEntreprise()
    {
        RestauLuxe = Random.Range(1, Habitants/400);
        RestauBio = Random.Range(1, Habitants/400);
        RestauFastFood= Random.Range(1, Habitants/400);
        RestauNBR = RestauLuxe + RestauFastFood + RestauBio;
        
        VeloCourse = Random.Range(1, Habitants/400);
        VeloVTT = Random.Range(1, Habitants/400);
        VeloElectric = Random.Range(1, Habitants/400);
        VeloNBR = VeloCourse + VeloVTT + VeloElectric;

        CoachSport = Random.Range(1, Habitants/400);
        CoachEntreprise = Random.Range(1, Habitants/400);
        CoachSelfDeveloppement = Random.Range(1, Habitants/400);
        CoachNBR = CoachEntreprise + CoachEntreprise + CoachSelfDeveloppement;

        VetementLuxe = Random.Range(1, Habitants/400);
        VetementSport = Random.Range(1, Habitants/400);
        VetementTechWear = Random.Range(1, Habitants/400);
        VetementNBR = VetementLuxe + VetementSport + VetementTechWear;
    }
}
