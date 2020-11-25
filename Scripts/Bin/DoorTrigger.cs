using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
  void OnTriggerEnter2D (Collider2D hitInfo) // when bullet hits another collider 
    {
        PlayerMovement player = hitInfo.GetComponent<PlayerMovement>(); // sees if the player has made contact with the it
        if (player.HasKey  == true) // if it has 
        {
        
        }
    }
}