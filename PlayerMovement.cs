using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f; // speed the player moves at
    public Rigidbody2D rb; // the players rigidbody
    private Camera cam; // the camera used for aiming 
    Vector2 movement; // used to get x and y vectors 
    Vector2 mousePos; // used to get the position of the mouse
    public bool HasKey = false; // boolean for whether the player picking up the key
    public int MaxHealth = 100; // max health of the player 
	public int CurrentHealth; // current health of the player 
    public HealthBar healthBar; // the health bar for the player
    public GameObject UIKey; // UI element shown once the player picks up the key

    void Awake ()
    {
        cam = Camera.main; // sets camera used for aiming to the main camera 
        CurrentHealth = MaxHealth; // sets the players health at the start of the game to the max 
    }
    void Update () // in update to get inputs as frequently as possible
    {
        movement.x = Input.GetAxisRaw("Horizontal"); /* sets the X vector by getting the Horizonal input 
        (Either -1(A or left arrow) 0(No input) or 1(D or right arrow) ) and updating every frame */
        movement.y = Input.GetAxisRaw("Vertical"); // same as above with Y vector and Up arrow/ W key and Down arrow/ S key
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition); // points the player in the direction of the mouse 

        if(HasKey == true) // checks to see if the players picked up the key
        {
            UIKey.SetActive(true); // shows the key in the UI
        }
    }

    void FixedUpdate() // in fixed update so speed cant be changed by frame rate
{
    rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); /* moves the player by getting its current position
    getting the x/y movement vectors and then multiplying it by movespeed and fixeddeltatime to keep the player moving at a constant rate*/
    Vector2 lookDir = mousePos - rb.position; // sets the lookdir to the mousepos variable and then takes minus the players position
    float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f; // sets the direction the players looking and then -90 so the mouse is in front of the player 
    // rather than behind 
    rb.rotation = angle; // sets the rotation of the player to the direction of the mouse
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

	void Die ()  
	{
		Destroy(gameObject); // destroy the player
        GameManager.Restart (); // restart the level
        GameManager.DeathsCounter ++; // Adds one to the players death counter
        Debug.Log ("Deaths: " + GameManager.DeathsCounter);
	}
}