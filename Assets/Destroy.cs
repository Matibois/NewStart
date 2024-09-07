using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public Dialogue d;

    public void DestroyThis()
    {
        d.DialogTrigger();
        d.EnableDialog();
        Destroy(gameObject);
    }
}
