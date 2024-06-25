using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllDialogs : MonoBehaviour
{
    public Dialogue D;
    private int DialogIndex;

    private void Start()
    {
        DialogIndex = 1;
        DialogList();
    }

    public void DialogTrigger()
    {
        if (D.dialogDone == true)
        {
            DialogIndex++;
            DialogList();
        }
        else if (D.dialogDone == false)
        {
            D.skipDialog = true;
        }
    }


   public void DialogList()
    {
        if (DialogIndex == 1) D.DialogFunction("Blablablabla");
        if (DialogIndex == 2) D.DialogFunction("BlebleblebleBlebleblebleBlebleblebleBlebleb" +
            "lebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBleblebleble");
        if (DialogIndex == 3) D.DialogFunction("AAAAAAAAAAAAABlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBleblebleble BlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleblebleBlebleble");
    }

}
