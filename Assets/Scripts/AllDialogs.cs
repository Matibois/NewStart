using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllDialogs : MonoBehaviour
{
    public Dialogue D;
    private int DialogIndex = 0;

   public void DialogList()
    {
        DialogIndex++;
        if (DialogIndex == 1) D.DialogFunction("Blablablabla");
        if (DialogIndex == 2) D.DialogFunction("BlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBleblebleble");
    }

}
