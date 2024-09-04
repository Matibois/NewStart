using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    public GameObject redCar; // L'objet à instancier
    public GameObject blueCar; // L'objet à instancier
    public Transform pointA;         // Point de départ (A)
    public Transform pointB;         // Point d'arrivée (B)
    private float carChoose = 0f;
    private float speed = 5f;         // Vitesse de déplacement
    private float timer = 5f;
    private float spawnInterval = 5f;

    private GameObject spawnedObject;
    void Update()
    {
        // Incrémenter le timer avec le temps écoulé depuis la dernière frame
        timer += Time.deltaTime;

        // Vérifie si l'intervalle de temps est atteint
        if (timer >= spawnInterval)
        {
            // Réinitialise le timer
            speed = Random.Range(8, 11);
            timer = 0f;
            spawnInterval = Random.Range(2, 7);
            carChoose = Random.Range(0,2);

            if (carChoose < 0.4f)
            {
                // Instancie une nouvelle voiture à la position du point A
                GameObject car = Instantiate(blueCar, pointA.position, Quaternion.identity);
                MoveCar(car);
            }
            else
            {
                // Instancie une nouvelle voiture à la position du point A
                GameObject car = Instantiate(redCar, pointA.position, Quaternion.identity);
                MoveCar(car);
            }


        }
    }

    void MoveCar(GameObject car)
    {
        // Déplacement de la voiture du point A vers le point B
        car.AddComponent<CarMovement>().Initialize(pointB.position, speed);
    }
}

