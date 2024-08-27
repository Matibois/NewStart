using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    static public Action<bool> canMoveEvent;

    private bool canMove;
    


    private void Start()
    {

    }

    private void StopMovement()
    {
        canMove = false;
        canMoveEvent?.Invoke(canMove);
    }

    private void PlayMovement()
    {
        canMove = true;
        canMoveEvent?.Invoke(canMove);
    }

}
