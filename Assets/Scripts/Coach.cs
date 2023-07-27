using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coach 
{
    public Entreprise.CoachType Type;
    public int Grade;

    public Coach(Entreprise.place lieu)
    {
        int grade = Grade;

    }

    private Coach[] CoachArray(int CoachNBR)
    {
        for (int i = 0; i < CoachNBR; i++)
        {
            Entreprise.CoachType coachType = setCoachType();
            int grade = setCoachGrade();
        }
        return CoachArray(CoachNBR);
    }

    private Entreprise.CoachType setCoachType()
    {
        int random = Random.Range(0, 3);

        switch (random)
        {
            case 0:
                return Type =  Entreprise.CoachType.Sport;
            case 1:
                return Type = Entreprise.CoachType.Entreprise;
            default:
                return Type = Entreprise.CoachType.SelfDeveloppement;
        }
    }

    private int setCoachGrade()
    {
        return Grade = Random.Range(1, 6);
    }
}
