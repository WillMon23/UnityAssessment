using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuBehavior : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool gameIsPaused;
    public Text scoreText;



    public void PauseGame()
    {
        if (!pauseMenu.activeInHierarchy)
        {
            
            pauseMenu.SetActive(true);
            gameObject.SetActive(false);
            scoreText.text = "Score: " + ScoreManagerBehavior.currentScore;
            gameIsPaused = true;
            Time.timeScale = 0f;
        }
    }

    public void UnPauseGame()
    {
        if (pauseMenu.activeInHierarchy)
        {
            pauseMenu.SetActive(false);
            gameObject.SetActive(true);
            gameIsPaused = false;
            Time.timeScale = 1;
        }

    }
}
