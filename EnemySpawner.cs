using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Script used for spawning the enemys, placed on a gameobject. this gameobject can then be duplicated and placed in different
places across the map to create different spawn points */

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy; // enemy gameobject
    public float StartSpawn = 1f; // how long after the game starts that the enemys will start spawning 
    public float SpawnDelay = 30f; // time between enemys spawning 
    void Start()
    {
        InvokeRepeating("SpawnObject", StartSpawn, SpawnDelay); // spawns the enemys on a delay after a given time
    }

 public void SpawnObject ()  
 {
     Instantiate(Enemy, transform.position, transform.rotation); // spawns the enemy game object at the position of the enemyspawn gameobject that this script is attached to
 }
}
