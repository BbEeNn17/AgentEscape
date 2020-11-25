using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* script used for the players bullet, will only damage enemys*/

public class PlayerBullet : MonoBehaviour
{
  public float speed = 10f; // speed of bullet
  public int damage = 20; // damage of bullet
  public Rigidbody2D Rigidbody; // rb attached to bullet
  public float range; // how long the bullet will stay in the game for before its destoryed 
    void Start() // when bullet is spawned in
    {
        Rigidbody.velocity = transform.up * speed; // sets velocity of the bullet and times it by speed variable
    }

    void OnTriggerEnter2D (Collider2D collider) // when bullet hits another collider 
    {
        Enemy enemy = collider.GetComponent<Enemy>(); // checks to see if the bullet has hit an object with the Enemy script attached'
        if (enemy != null) // if it has hit enemy 
        {
          enemy.TakeDamage(damage); // call TakeDamage function from enemy class
        }
        Debug.Log(collider.name); // prints to log the name of the object its hit
        Destroy(gameObject); // destroys the bullet once its hit an object with a collider on it
    }

    void Update () // called every frame
    {
      Destroy(gameObject, range); // destroy bullet after 'range variable' if it doesn't hit anything 
    }
}