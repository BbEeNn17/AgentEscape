using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* enemy bullet script used to control the enemys bullet - wont damage anything other than the player 
so therefore the enemys cant accidentally damage or kill each other*/
public class EnemyBullet : MonoBehaviour
{
  public float speed = 10f; // speed of bullet
  public int damage = 20; // damage of bullet
  public Rigidbody2D Rigidbody; // rb attached to bullet
  public float range; // how long the bullet wil travel before being destroyed
    void Start() // when bullet is spawned in
    {
        Rigidbody.velocity = transform.up * speed; // sets velocity of the bullet and times it by speed variable
    }

    void OnTriggerEnter2D (Collider2D collider) // when bullet hits another collider 
    {
        PlayerMovement player = collider.GetComponent<PlayerMovement>(); // checks to see if the bullet has hit an object named with the player movement script attached
        if (player != null) // if it has the player 
        {
          player.TakeDamage(damage); // call TakeDamage function from player class
         
        }
        Debug.Log(collider.name); // prints to log the name of the object its hit
         // destroys the bullet once its hit an object with a collider on it 
         Destroy(gameObject); // detroys bullet when it hits player
    }

    void Update () // called every frame
    {
      Destroy(gameObject, range); // destroy bullet if it doesn't hit anything 
    }
}