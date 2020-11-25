using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void  Play () // used by the play button
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // loads the next level (Scene 1 as menu is scene 0)
    }

    public void Quit () // used by the quit button
    {
        Application.Quit(); // quits the application
        Debug.Log("Quit"); // used for testing as cant close application from inside unity
    }
}
