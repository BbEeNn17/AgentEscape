using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{

    public GameObject UI; // end of level UI

void start () 
{
    UI.SetActive(false); // disables the end of level UI 
}

         void OnTriggerEnter2D (Collider2D Collider) //collision detector on on the end level trigger gameObject
    {
        PlayerMovement player = Collider.GetComponent<PlayerMovement>(); // gets the players collider component 
        if (player != null) // if the object that collides is the player 
        {
           UI.SetActive(true); // enables the end of level UI
           GameManager.LevelCompleted() ; // calls the level completed function from the gamemanager script 
           Debug.Log("Level completed!");
           Destroy(player); // destroys the player to they cant be killed by enemys after the levels completed and stops them walking in 
           // and out of the end of game trigger to keep adding points to their score 
}

    }
}