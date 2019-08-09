using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{

    public BallRandomStartCount BallRandomStart;
    public GameManager gameManager;
    public GameObject inGameView;
    public GameObject MainMenu;
    public GameObject gameOver;
    public GameObject pauseMenu;
    public GameObject slash;
    public GameObject slash2;
    public GameObject pauseButton;
    public GameObject tutorial;
    public GameObject Ball;
    public GameObject Foot;

    public int highScore;
    bool isMute;


    void Start()
    {
        highScore = gameManager.GetHighScore();
        inGameView.SetActive(false);
        gameOver.SetActive(false);
        pauseMenu.SetActive(false);
        slash.SetActive(false);
        slash2.SetActive(false);
        Ball.SetActive(false);
        Foot.SetActive(false);
    }

    public void StartGame()
    {
        inGameView.SetActive(true);
        MainMenu.SetActive(false);
        gameOver.SetActive(false);
        pauseButton.SetActive(true);
        pauseMenu.SetActive(false);
        Ball.SetActive(true);
        Foot.SetActive(true);

        BallRandomStart.RandomStartPosition();
        StartCoroutine(this.BallRandomStart.StartBall(true));
        gameManager.ResetScore();
        highScore = gameManager.GetHighScore();
        
        Time.timeScale = 1;
    }

    

    public void Mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;

        if (isMute)
        {
            slash.SetActive(true);
            slash2.SetActive(true);
        } else
        {
            slash.SetActive(false);
            slash2.SetActive(false);
        }
    }

    public void GoToMainMenu()
    {
        MainMenu.SetActive(true);
        gameOver.SetActive(false);
        pauseMenu.SetActive(false);
        inGameView.SetActive(false);
        tutorial.SetActive(false);
        Ball.SetActive(false);
        Foot.SetActive(false);
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
