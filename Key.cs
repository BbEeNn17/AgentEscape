using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour

{
float RotationSpeed = 50.0f; // how fast the key will rotate

    void Update()
    {
        transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime); // rotate the prefab on the z axis
    }
        void OnTriggerEnter2D (Collider2D Collider) // checks for collision
    {
        PlayerMovement player = Collider.GetComponent<PlayerMovement>(); // if it collides with the player 
        if (player != null) 
        {
             player.HasKey = true; // sets the 'HasKey' boolean on the player to true
             PickedUp (); // calls picked up method 
             Debug.Log(Collider.name + " picked up key"); 
        }
        
    }
    public void PickedUp () 
    {
        Destroy(gameObject); // destroys the key once its been picked up
    }
}
