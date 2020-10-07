using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/* script used to control scene management as well as rembering the players points and how many times they've died as well as controlling 
some UI elements*/

public class GameManager : MonoBehaviour {
 public static float GamePoints; // to keep a count of the players points

 public TextMeshProUGUI Points; // to display the players points to the ui at the end of the level
 public static int DeathsCounter; // count deaths to subtract points from final score
public static float leveltimer = 300f; // used in the countdown script
 private static float delay = 1000f; // used once the level is compelted 
    void awake()
    {
        AstarPath.active.Scan(); // calls the astar method which scans the map for obsticles for AI to go around 
        
    }
void Update() 
     {
         delay -= Time.deltaTime; // the delay is set to 5 seconds once the game ends - set to 1000 before the game starts so it doesnt begin the next level during play
         if(delay < 0) // used so at the end of the level the 'Level Completed UI' will show for a few seconds before starting the next level
         {
             LoadNextLevel (); // calls next level function
         }
         Points.text = "Points so far:" + GamePoints.ToString(); // converts the points gained so far to a string so it can be output to the UI points element 
     }
    
public static void Restart () 
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().name); // reloads the current scene
}

public static void LevelCompleted () 
    { 
            GamePoints = GamePoints + Countdown.levelpoints; // adds the points gained in the level to all the points gained so far 
            Debug.Log("Points" + GamePoints); 
            delay = 5f; // sets the delay for the level compelted UI screen to 5 seconds
    }

public static void LoadNextLevel () 
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // gets the current scene index and adds 1 to it and then loads that scene
    delay = 1000f; // resets the timer to start the next level to 1000 seconds 
}

}
