using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootMovementController : MonoBehaviour
{

    private Rigidbody rb;
    [Header("Player Controls")]
    public float speed;
    public float rotationFactor;
    public bool mobileControl;

    [Header("AI Elements")]
    public bool isAI;
    public GameObject ball;
    private float footWidth;
    public float reactFactor =1;
    private float AISpeed;
    public float jitterFactor;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        footWidth = transform.localScale.x;
        //speed = PlayerPrefs.GetFloat("BootSpeed", 60);
    }


    private void FixedUpdate()
    {
        if (!isAI)
        {
            if (mobileControl)
            {
                Vector3 dir = Vector3.zero;
                dir.x = Input.acceleration.x;
                rb.velocity = dir * speed;
            }
            else
            {
                float h = Input.GetAxis("Horizontal");
                rb.velocity = new Vector3(h, 0, 0) * speed;
            }

        } else
        {
            float posX = this.transform.position.x;
            float ballX = ball.transform.position.x;
            AISpeed = Mathf.Abs(posX - ballX) * speed / jitterFactor;

            if (Mathf.Abs(posX - ballX) > footWidth/reactFactor)
            {
                if (posX < ballX)
                {
                    rb.velocity = new Vector3(1, 0, 0) * AISpeed;
                }
                else
                {
                    rb.velocity = new Vector3(-1, 0, 0) * AISpeed;
                }
            }
            else
            {
                rb.velocity = new Vector3(0, 0, 0);
            }

        }

        float degrees = this.transform.position.x * rotationFactor;
        this.transform.rotation = Quaternion.Euler(Vector3.forward * degrees);

    }
}

