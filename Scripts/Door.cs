using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

void OnTriggerEnter2D (Collider2D Collider)  // when an object enters its collion area set to trigger
    {
        PlayerMovement player = Collider.GetComponent<PlayerMovement>(); /* gets the players collider component by seeing what 
        game objects have the playermovement script attactched */
        if (player.HasKey == true) // checks to see if the player has picked up the key
        {
             Destroy(gameObject); // if the player has the key - destroy the door game object 
        }
        else // if the player doesn't have the key
        {
            Debug.Log("Find The Key!"); 
        }
        
    }

}