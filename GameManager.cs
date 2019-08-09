using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public Animator anim;
    public GameObject AnimationT;
    public Text HighScoreText;
    

    public GameObject scoreTextPlayer1;
    public GameObject highScoreTextPlayer1;
    public DifficultyCurber dc;

    public int increaseDiffLevel1 = 10;
    public int increaseDiffLevel2 = 20;
    public int increaseDiffLevel3 = 30;
    public int increaseDiffLevel4 = 40;

    public GameObject medal20IG;
    public GameObject medal40IG;
    public GameObject medal60IG;
    public GameObject medal80IG;
    public GameObject medal100IG;

    public Text EncourageText;

    private void Awake()
    {
        // get high score
        HighScoreText.text = GetHighScore().ToString();

        anim = AnimationT.GetComponent<Animator>();
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    private void Update()
    {

        scoreText.text = score.ToString();


        if (score == 0)
        {
            dc.GetHarder0();
            medal20IG.SetActive(false);
            medal40IG.SetActive(false);
            medal60IG.SetActive(false);
            medal80IG.SetActive(false);
            medal100IG.SetActive(false);

            EncourageText.text = ("");
        }
        if (score == increaseDiffLevel1)
        {
            dc.GetHarder1();
        }
        if (score == increaseDiffLevel2)
        {
            dc.GetHarder2();
        }
        if (score == increaseDiffLevel3)
        {
            dc.GetHarder3();
        }
        if (score == increaseDiffLevel4)
        {
            dc.GetHarder4();
        }

        if (score == 10)
        {
            EncourageText.text = ("now you're getting the hang of it");
        }

        if (score == 20)
        {
            medal20IG.SetActive(true);
            EncourageText.text = ("20 already?? Here, have a medal");
        }

        if (score == 30)
        {
            EncourageText.text = ("Yeah, you're getting pretty good");
        }

        if (score == 40)
        {
            medal40IG.SetActive(true);
            EncourageText.text = ("How Long can you hold on for!?");
        }

        if (score == 50)
        {
            EncourageText.text = ("Nifty at 50!");
        }

        if (score == 60)
        {
            medal60IG.SetActive(true);
            EncourageText.text = ("Woo Gold Medal! keep going!");
        }

        if (score == 70)
        {
            EncourageText.text = ("Ok now you're just showing off");
        }

        if (score == 80)
        {
            medal80IG.SetActive(true);
            EncourageText.text = ("Platinum? Surely you can do better");
        }

        if (score == 90)
        {
            EncourageText.text = ("almost there...");
        }

        if (score == 100)
        {
            medal100IG.SetActive(true);
            EncourageText.text = ("BOOM! 100! Rainbow medal for you!");
        }

        if (score == 110)
        {
            EncourageText.text = ("");
        }

        if (score == 120)
        {
            EncourageText.text = ("You're still going huh?");
        }

        if (score == 130)
        {
            EncourageText.text = ("");
        }

        if (score == 140)
        {
            EncourageText.text = ("You've already beaten the game");
        }

        if (score == 150)
        {
            EncourageText.text = ("");
        }

        if (score == 160)
        {
            EncourageText.text = ("I haven't even got this far before");
        }

        if (score == 170)
        {
            EncourageText.text = ("");
        }

        if (score == 180)
        {
            EncourageText.text = ("Ok, this is getting a bit out of hand");
        }

        if (score == 190)
        {
            EncourageText.text = ("");
        }

        if (score == 200)
        {
            EncourageText.text = ("I really didn't think anyone would get this far");
        }

        if (score == 210)
        {
            EncourageText.text = ("");
        }

        if (score == 300)
        {
            EncourageText.text = ("This is starting to get impressive aagain");
        }
        if (score == 310)
        {
            EncourageText.text = ("");

        }
        if (score == 500)
        {
            EncourageText.text = ("You are a God among insects");

        }
        if (score == 510)
        {
            EncourageText.text = ("");

        }
        if (score == 1000)
        {
            EncourageText.text = ("I can't even");
        }
        if (score == 1010)
        {
            EncourageText.text = ("I can't even");
        }
        if (score == 1989)
        {
            EncourageText.text = ("1989, when I was born");
        }
        if (score == 2000)
        {
            EncourageText.text = ("");
        }
    }


    public void IncreaseScore()
    {
        score++;
        anim.Play("ScoreCount");
        scoreText.text = score.ToString();

        if(score > GetHighScore())
        {
            PlayerPrefs.SetInt("Highscore", score);
            HighScoreText.text = score.ToString();
        }

    }

    public int GetHighScore()
    {
        int i = PlayerPrefs.GetInt("Highscore");
        return i;
    }

    public void ResetScore()
    {
        score = 0;

    }
}
