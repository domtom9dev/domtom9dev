using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoDisable : MonoBehaviour
{
    private float disableTime = 2.5f;
    public GameObject logo;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > disableTime)
        {
            logo.SetActive(false);
        }
        
    }
}
