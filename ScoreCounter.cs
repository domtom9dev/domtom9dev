using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public float delayTime;
    public float repeatRate;

    public Text scoreCountText;
    public GameManager gameManager;
    public GameObject newHighScoreTxt;
    public GameObject medal20;
    public GameObject medal40;
    public GameObject medal60;
    public GameObject medal80;
    public GameObject medal100;

    public AudioSource music20;
    public AudioSource music40;
    public AudioSource music60;
    public AudioSource music80;
    public AudioSource music100;



    public ButtonController buttonController;
    public AudioSource littleBing;
    public AudioSource bigBing;
    public AudioSource music0;

    //public AudioSource celebrateClip;

    int runningScore;
    int score;
    int oldHighScore;

    private void Start()
    {
        medal20.SetActive(false);
        medal40.SetActive(false);
        medal60.SetActive(false);
        medal80.SetActive(false);
        medal100.SetActive(false);
    }

    public void StartCounting()
    {
        InvokeRepeating("Count", delayTime, repeatRate);
        score = gameManager.score;
        
        runningScore = 0;
    }

    public void Count()
    {
        music0.volume = 0.2f;
        if (runningScore < score)
        {
            runningScore++;
            scoreCountText.text = runningScore.ToString();
            littleBing.Play();
        }

        if (runningScore == 20)
        {
            medal20.SetActive(true);
            music20.Play();
        }
        if (runningScore == 40)
        {
            medal40.SetActive(true);
            music40.Play();
        }
        if (runningScore == 60)
        {
            medal60.SetActive(true);
            music60.Play();
        }
        if (runningScore == 80)
        {
            medal80.SetActive(true);
            music80.Play();
        }
        if (runningScore == 100)
        {
            medal100.SetActive(true);
            music100.Play();
        }



        if (runningScore == score)
        {

            CancelInvoke();
            bigBing.Play();
            music0.volume = 0.5f;
        }

        oldHighScore = buttonController.highScore;
        if (runningScore > oldHighScore)
        {
            newHighScoreTxt.SetActive(true);
            //celebrateClip.Play();

        }
    }


    public void Update()
    {

    }
}
