using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour
{
    public float movementSpeed;
    public bool isAI;
    public GameObject ball;

    private void Update()
    {

        float ballH = ball.transform.position.y;
        float objH = transform.position.y;

        if (ballH > objH)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * movementSpeed;
        }
        else if (ballH < objH)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * movementSpeed;
        }
    }
}
