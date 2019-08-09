using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyCurber : MonoBehaviour
{

    //if score hits a certain amount 
    //i want the camera to move away 
    //and the level constraints to widen

    public GameObject mainCamera;
    public GameObject levelConstraints;
    public float lerpTime;

    public AudioSource music0;

    public FootMovementController foot;
    private float footSpeed0 = 60;
    private float footSpeed1 = 70;
    private float footSpeed2 = 80;
    private float footSpeed3 = 90;
    private float footSpeed4 = 100;

    private Vector3 Camera0 = new Vector3(0, 8, -25);
    private Vector3 Camera1 = new Vector3(0, 11, -32.5f);
    private Vector3 Camera2 = new Vector3(0, 14, -40);
    private Vector3 Camera3 = new Vector3(0, 17, -47.5f);
    private Vector3 Camera4 = new Vector3(0, 20, -55);

    private Vector3 LevelCon0 = new Vector3(1, 1, 1);
    private Vector3 LevelCon1 = new Vector3(1.25f, 1.25f, 1.25f);
    private Vector3 LevelCon2 = new Vector3(1.5f, 1.5f, 1.5f);
    private Vector3 LevelCon3 = new Vector3(1.75f, 1.75f, 1.75f);
    private Vector3 LevelCon4 = new Vector3(2.2f, 2.2f, 2.2f);



    public void GetHarder0()
    {
        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, Camera0, Time.deltaTime);
        levelConstraints.transform.localScale = Vector3.Lerp(levelConstraints.transform.localScale, LevelCon0, Time.deltaTime);
        foot.speed = footSpeed0;
        music0.pitch = 1f;
    }

    public void GetHarder1()
    {
        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, Camera1, Time.deltaTime);
        levelConstraints.transform.localScale = Vector3.Lerp(levelConstraints.transform.localScale, LevelCon1, Time.deltaTime);
        foot.speed = footSpeed1;
        music0.pitch = 1.1f;

    }

    public void GetHarder2()
    {
        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, Camera2, Time.deltaTime);
        levelConstraints.transform.localScale = Vector3.Lerp(levelConstraints.transform.localScale, LevelCon2, Time.deltaTime);
        foot.speed = footSpeed2;
        music0.pitch = 1.2f;

    }

    public void GetHarder3()
    {
        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, Camera3, Time.deltaTime);
        levelConstraints.transform.localScale = Vector3.Lerp(levelConstraints.transform.localScale, LevelCon3, Time.deltaTime);
        foot.speed = footSpeed3;
        music0.pitch = 1.3f;

    }

    public void GetHarder4()
    {
        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, Camera4, Time.deltaTime);
        levelConstraints.transform.localScale = Vector3.Lerp(levelConstraints.transform.localScale, LevelCon4, Time.deltaTime);
        foot.speed = footSpeed4;
        music0.pitch = 1.4f;

    }
}
