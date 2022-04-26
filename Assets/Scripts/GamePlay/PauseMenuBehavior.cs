using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Handles the games pause button functionality 
public class PauseMenuBehavior : MonoBehaviour
{
    //Gets the refrence to the pause menu
    public GameObject pauseMenu;
    //static value to keeps tabs on the active need of the pasue menu
    public static bool gameIsPaused;
    //Gets a refrence to the text box 
    public Text scoreText;


    //Meant to pause the game
    public void PauseGame()
    {
        //checks the pause menu is not active in the hierarchy
        if (!pauseMenu.activeInHierarchy)
        {
            //Sets pasue menu to be active
            pauseMenu.SetActive(true);
            //Sets this game object to be false
            gameObject.SetActive(false);
            //Updates the score in the pause menu
            scoreText.text = "Score: " + ScoreManagerBehavior.currentScore;
            //The Game is now paused
            gameIsPaused = true;
            //Sets the time scale to be 0
            //Puting the game to a stand still
            Time.timeScale = 0f;
        }
    }

    //Meant to un pause the game 
    public void UnPauseGame()
    {
        //checks the pause menu is active in the hierarchy
        if (pauseMenu.activeInHierarchy)
        {
            //Makes the pause menu active to be false
            pauseMenu.SetActive(false);
            //Activates this game object 
            gameObject.SetActive(true);
            //the game is no longer paused
            gameIsPaused = false;
            //Sets the time scale to be 1
            //Making everything move again
            Time.timeScale = 1f;
        }

    }
}
