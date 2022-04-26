using UnityEngine;
using UnityEngine.SceneManagement;

//Handles the event for most of the games button 
public class GameManagerController : MonoBehaviour
{
    //maintain the current scene
    private Scene thisScene;

    //refrence to the how to play menu
    [SerializeField] private GameObject _howToPlay;

    // Update is called once per frame
    void Update()
    {
        //Gets the current active scene 
        thisScene = SceneManager.GetActiveScene();
    }

    //Game Over Event Button 
    public void GameOver()
    {
        //Testing if the game has quit or not 
        Debug.LogWarning("Game was Quit");
        //Meant to close rhe game application 
        Application.Quit();
    }

    //Restarts Game 
    public void RestartGame()
    {
        //If the pause menu is pasued 
        if (PauseMenuBehavior.gameIsPaused)
            //Sets the time Scale to 1f to us pause it
            Time.timeScale = 1f;

        //Resets current score
        ScoreManagerBehavior.currentScore = 0;
        //Loads the current scene again 
        SceneManager.LoadScene(thisScene.name);
    }

    //Load the start menu scene
    public void StartGame()
    {
        SceneManager.LoadScene("TrackOne");
    }

    //Moves scene to the main menu
    public void MainMenu()
    {
        //Restest current score back to 0
        ScoreManagerBehavior.currentScore = 0;
        //Changes Load Scene To be the main scene 
        SceneManager.LoadScene("MainMenu");
    }

    //Dis plays the how to play menu 
    public void HowTOPlay()
    {
        //If the how to play menu is has a refrence 
        if (_howToPlay)
        {
            //if the object is not active
            if (!_howToPlay.active)
                //Change it to true
                _howToPlay.active = true;
            //Other wise make it false
            else _howToPlay.active = false;
        }
    }
}
