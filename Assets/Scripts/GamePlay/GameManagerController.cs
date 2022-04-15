using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerController : MonoBehaviour
{
    private Scene thisScene;

    // Update is called once per frame
    void Update()
    {
        thisScene = SceneManager.GetActiveScene();
    }

    public void GameOver()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        if (PauseMenuBehavior.gameIsPaused)
            Time.timeScale = 1f;
        SceneManager.LoadScene(thisScene.name);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("TrackOne");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
