using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    public GameObject redCar; // L'objet � instancier
    public GameObject blueCar; // L'objet � instancier
    public Transform pointA;         // Point de d�part (A)
    public Transform pointB;         // Point d'arriv�e (B)
    private float carChoose = 0f;
    private float speed = 5f;         // Vitesse de d�placement
    private float timer = 5f;
    private float spawnInterval = 5f;

    private GameObject spawnedObject;
    void Update()
    {
        // Incr�menter le timer avec le temps �coul� depuis la derni�re frame
        timer += Time.deltaTime;

        // V�rifie si l'intervalle de temps est atteint
        if (timer >= spawnInterval)
        {
            // R�initialise le timer
            speed = Random.Range(8, 11);
            timer = 0f;
            spawnInterval = Random.Range(2, 7);
            carChoose = Random.Range(0,2);

            if (carChoose < 0.4f)
            {
                // Instancie une nouvelle voiture � la position du point A
                GameObject car = Instantiate(blueCar, pointA.position, Quaternion.identity);
                MoveCar(car);
            }
            else
            {
                // Instancie une nouvelle voiture � la position du point A
                GameObject car = Instantiate(redCar, pointA.position, Quaternion.identity);
                MoveCar(car);
            }


        }
    }

    void MoveCar(GameObject car)
    {
        // D�placement de la voiture du point A vers le point B
        car.AddComponent<CarMovement>().Initialize(pointB.position, speed);
    }
}

