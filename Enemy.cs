using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*Enemys script, used for taking damage and controlling the health bar on the enemy*/

public class Enemy : MonoBehaviour {
	public int MaxHealth = 100; // enemys max health
	public int CurrentHealth; // current health of the enemy 
	public HealthBar healthBar; // to insert healthbar slider in ide
	
	void Start () // called at beggining of game
	{
		CurrentHealth = MaxHealth; // sets current health of Enemy to its MaxHealth  at beggining of game
		healthBar.SetMaxHealth(MaxHealth); // calls the setmaxhealth fucntion from the healthabr script and sets it to the maxhealth 
	}
	public void TakeDamage (int damage) // take damage function 
	{
		CurrentHealth -= damage; // health of enemy minus damage taken
		healthBar.SetHealth(CurrentHealth);

		if (CurrentHealth <= 0) // if health is less than or equal to 0 
		{
			Die(); // calls die function
			
		}
	}

	void Die () // die function 
	{
		Destroy(gameObject); // gets rid of enemy 
	}
}
