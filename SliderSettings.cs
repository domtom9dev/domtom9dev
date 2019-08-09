using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSettings : MonoBehaviour
{
    public float bootSpeed;
    public float bootWeight;
    public float ballWeight;
    public float gravityConstant;

    public GameObject saved;

    private void Awake()
    {
        saved.SetActive(false);
    }

    public void AdjustBootSpeed(Slider newBootSpeed)
    {
        bootSpeed = newBootSpeed.value;
        saved.SetActive(false);
        Debug.Log(bootSpeed);
    }

    public void AdjustBootWeight(Slider newBootWeight)
    {
        bootWeight = newBootWeight.value;
        saved.SetActive(false);
        Debug.Log(bootWeight);
    }

    public void AdjustBallWeight(Slider newBallWeight)
    {
        ballWeight = newBallWeight.value;
        saved.SetActive(false);
        Debug.Log(ballWeight);
    }


    public void AdjustGravityConstant(Slider newGravityConstant)
    {
        gravityConstant = newGravityConstant.value;
        saved.SetActive(false);
        Debug.Log(gravityConstant);
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetFloat("BootSpeed", bootSpeed);
        PlayerPrefs.SetFloat("BootWeight", bootWeight);
        PlayerPrefs.SetFloat("BallWeight", ballWeight);
        PlayerPrefs.SetFloat("GravityConstant", gravityConstant);

        saved.SetActive(true);
    }
}
