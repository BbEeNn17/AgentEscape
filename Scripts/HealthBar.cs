using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* Script used for controlling the players health bar - which is a slider inside an image */
public class HealthBar : MonoBehaviour
{
	public Slider slider; // to insert the slider in the IDE
	public void SetMaxHealth(int health) // set max health function that takes in an integer 
	{
		slider.maxValue = health; // sets the maximum number the slider can go up to to the players starting health
		slider.value = health; // sets the sliders current state the players health

	}

    public void SetHealth(int health) // used for setting the current state of the health bar 
	{
		slider.value = health; // sets the sliders value to the current health of the player 
	}
}



