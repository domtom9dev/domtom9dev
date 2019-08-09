using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallRandomStartCount : MonoBehaviour
{
    //public int startPause;

    public float minY;
    public float maxY;
    private float y;

    public float minX1;
    public float maxX1;
    private float x1;

    public float minX2;
    public float maxX2;
    private float x2;

    Rigidbody rb;
    public GameObject countDown;
    public AudioSource whistle;

    public GameObject InGameView;
    public GameObject foot;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(this.StartBall());
        Text countDownText = this.countDown.GetComponent<Text>();
        InGameView.SetActive(true);
        foot.transform.position = new Vector3(0, -2, 0);
    }

    public void RandomStartPosition()
    {
        foot.transform.position = new Vector3(0, -2, 0);

        InGameView.SetActive(true);
        rb.useGravity = false;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        x1 = Random.Range(minX1, maxX1);
        x2 = Random.Range(minX2, maxX2);
        y = Random.Range(minY, maxY);

        float randomNumber = Random.Range(0, 10.0f);
        if (randomNumber <= 5)
        {
            transform.position = new Vector3(x1, y, 0);
        }
        else
        {
            transform.position = new Vector3(x2, y, 0);
        }
    }

    public IEnumerator StartBall(bool isRestarting = true)
    {
        RandomStartPosition();

        Text countDownText = this.countDown.GetComponent<Text>();
        countDownText.text = "Ready?";

        yield return new WaitForSeconds(1);
        countDownText.text = "Steady?";

        yield return new WaitForSeconds(1);
        countDownText.text = "Go!!";
        whistle.Play();

        rb.useGravity = true;


        yield return new WaitForSeconds(1);
        countDownText.text = "";
    }

    
}
