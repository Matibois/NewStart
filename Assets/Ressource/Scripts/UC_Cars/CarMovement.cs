using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    private Vector3 targetPosition;
    private float speed;

    public void Initialize(Vector3 targetPosition, float speed)
    {
        this.targetPosition = targetPosition;
        this.speed = speed;
    }

    void Update()
    {
        // Déplacer la voiture vers le point B
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Détruire la voiture lorsqu'elle atteint le point B
        if (transform.position == targetPosition)
        {
            Destroy(gameObject);
        }
    }
}
