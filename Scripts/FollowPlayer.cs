using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* a script to get the camera to follow the player, start find the game object named 'player'
and sets that to the player variable then the update method updates the cameras position with the 
same as the players */
public class FollowPlayer : MonoBehaviour
{

  private Transform player; // players position - found by the start method

    void Start ()
    {
      player = GameObject.Find("Player").transform; // gets the transform of the player 
    }
    void FixedUpdate ()
    {
        transform.position = new Vector3 (player.position.x, player.position.y, -1f); // updates the cameras position to be the same as the players 
    }
}

