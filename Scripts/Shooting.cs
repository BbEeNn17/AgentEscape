using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
   public Transform FirePoint; // location set in ide of where the bullet will spawn    
   private float ReloadTimer; // used to countdown from 
   public float TimeToReload = 0.5f; // time between the player being able to shoot
  public GameObject bulletPrefab; // bullet prefab being used
   void Update () // called every frame 
   {
       ReloadTimer -= Time.deltaTime; // counts down from the reloadtimer
       if (Input.GetButtonDown("Fire1")) //checks for 'fire1' button (left click in my game)
        {
           if (ReloadTimer <= 0) // when the reload timer reaches 0
           {
               Shoot(); // call shoot method 
           }
           else // if the player tries to shoot before the timer reaches 0
           {
               Debug.Log("Reloading");
           }
        }
   }   

    public void Shoot ()   // shoot method 
    {
        Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation); // spawns in bullet but with no force (done in Bullet.cs)
        ReloadTimer = TimeToReload; // once the player has shot this resets the reload timer to the TimeToReload variable 
    }
}

