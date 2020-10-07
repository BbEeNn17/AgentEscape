using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*The script used to countdown the players score on the player UI, calls the game managers restart method when the 
countdown reaches 0 */

public class Countdown : MonoBehaviour
{
     public TextMeshProUGUI timer; // to output the time left to the players ui
     private float timeLeft = GameManager.leveltimer; // time to complete the level
     public static float levelpoints; // used to store the time left at the end of the game 

     void start () 
     { 
         timer.text = timeLeft.ToString(); // converts timer to string so it can be displayed in UI element
     }
     
     void Update()
     {
         timeLeft -= Time.deltaTime; // countsdown from the timeleft variable
        levelpoints = timeLeft; // stores the time left in the level points varible to be used by the game manager script
         
         if(timeLeft < 0) 
         {
             GameManager.Restart (); // reloads the current scene
         }

        timer.text =  "Points: " + timeLeft.ToString() ; // outputs timer to UI element
    
     }
}
 
 
