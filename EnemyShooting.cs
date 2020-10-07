using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
public Transform FirePoint; // location set in ide of where the bullet will spawn    
public GameObject bulletPrefab; // bullet prefab being used
  
public float fireRate = 1f; // how often the enemy will shoot 
private float fireCountdown = 0f;


    void Update () 
    {
        if (fireCountdown <= 0f) // when the coundown reaches 0
        {
            Shoot(); // call shoot method 
            fireCountdown = 1f / fireRate; // calculates how fast gun will shoot by dividing one by the firerate and starting the countdown on that number 
        }

        fireCountdown -= Time.deltaTime;
    }

    void Shoot ()   // shoot method 
    {
            Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation); // spawns in bullet but with no force (done in Bullet.cs)
    }

}


 