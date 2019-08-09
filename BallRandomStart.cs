using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallRandomStart : MonoBehaviour
{
    public int startPause;

    public float minY;
    public float maxY;
    private float y;

    public float minX1;
    public float maxX1;
    private float x1;

    public float minX2;
    public float maxX2;
    private float x2;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(this.StartBall());
    }

    public IEnumerator StartBall(bool isRestarting = true)
    {
        rb.gravityScale = 0;
        rb.velocity = new Vector2(0,0);

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
        
        yield return new WaitForSeconds(2);

        rb.gravityScale = 1;
    }
}
