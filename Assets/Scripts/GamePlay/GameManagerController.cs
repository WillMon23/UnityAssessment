using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerController : MonoBehaviour
{
    private Scene thisScene;

    [SerializeField] private GameObject _howToPlay;

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
        ScoreManagerBehavior.currentScore = 0;
        SceneManager.LoadScene(thisScene.name);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("TrackOne");
    }

    public void MainMenu()
    {
        ScoreManagerBehavior.currentScore = 0;
        SceneManager.LoadScene("MainMenu");
    }

    public void HowTOPlay()
    {
        if (_howToPlay)
        {
            if (!_howToPlay.active)
                _howToPlay.active = true;
            else _howToPlay.active = false;
        }
    }
}
