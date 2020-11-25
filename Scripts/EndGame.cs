using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/* The script used in the final scene of the game once all the levels are completed */

public class EndGame : MonoBehaviour
{
    public TextMeshProUGUI GamePointsUI; // How many points the player accumaleted all together over the course of the game
    public TextMeshProUGUI DeathsUI; // how many deaths the player had throughout the game
    public TextMeshProUGUI FinalScoreUI; // the final score of the player - calculated by (Gamepoints - (Deaths * 5))
    public float FinalScore;

    void Start()
    {
        GamePointsUI.text = "Points earned: " + GameManager.GamePoints.ToString(); /* gets the game points from the game manager
        and converts it to a string to be displayed in the UI*/
        DeathsUI.text = "Deaths: " + GameManager.DeathsCounter.ToString(); // same as above but for the players deaths 
    }

    
    void Update()
    {
     FinalScore = GameManager.GamePoints - (GameManager.DeathsCounter * 20);   // calculates the final score 
     FinalScoreUI.text = "Final Score: " + FinalScore.ToString(); // converts final score to string for output to the UI
    }
}
