using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{

    public GameManager gameManager;
    public GameOver gameOver;



    Rigidbody rb;
    public AudioSource kick;
    //public AudioSource loose;


    private void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Foot")
        {
            gameManager.IncreaseScore();
            kick.Play();
        }

        if (collision.gameObject.name == "BarrierB")
        {
            rb.useGravity = false;
            rb.velocity = new Vector3(0, 0, 0);
            gameOver.GameOverScreen();
            

        }
    }

}
