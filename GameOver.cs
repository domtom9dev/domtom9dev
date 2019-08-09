using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject newHighScoreTxt;
    public GameObject gameOver;
    public GameObject inGameView;
    public ScoreCounter scoreCounter;
    public GameObject Foot;
    public AudioSource music0;

    public GameObject medal20;
    public GameObject medal40;
    public GameObject medal60;
    public GameObject medal80;
    public GameObject medal100;

    private void Start()
    {
        gameOver.SetActive(false);
    }
    

    public void GameOverScreen()
    {
        gameOver.SetActive(true);
        newHighScoreTxt.SetActive(false);
        inGameView.SetActive(false);
        Foot.SetActive(false);
        scoreCounter.StartCounting();
        music0.pitch = 1f;
        

        medal20.SetActive(false);
        medal40.SetActive(false);
        medal60.SetActive(false);
        medal80.SetActive(false);
        medal100.SetActive(false);
    }
}
