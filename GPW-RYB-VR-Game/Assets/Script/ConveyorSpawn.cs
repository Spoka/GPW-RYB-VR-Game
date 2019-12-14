using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorSpawn : MonoBehaviour
{
    public GameTimerScript timerScript;

    public GameObject spawnPoint;
    public Transform spawndCube;

    private Transform cubeFired;

    public float delay;
    private float currentDelay;
    private bool fireCube;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timerScript.GameTimer <= 180 && timerScript.GameTimer > 150)
        {
            delay = 2.25f;
        }
        if (timerScript.GameTimer <= 150 && timerScript.GameTimer > 120)
        {
            delay = 2.0f;
        }
        if (timerScript.GameTimer <= 120 && timerScript.GameTimer > 90)
        {
            delay = 1.75f;
        }
        if (timerScript.GameTimer <= 90 && timerScript.GameTimer > 60)
        {
            delay = 1.5f;
        }
        if (timerScript.GameTimer <= 60 && timerScript.GameTimer > 30)
        {
            delay = 1.25f;
        }
        if (timerScript.GameTimer <= 30 && timerScript.GameTimer > 0)
        {
            delay = 1.0f;
        }

        if (currentDelay == 0)                        //
        {                                             //
            Spawn();                                   //
        }                                             //
                                                      //
        if (fireCube && currentDelay < delay)         //Call Fire(spawn) method after Delay time
        {                                             //
            currentDelay += 1 * Time.deltaTime;       //          
        }                                             //          
                                                      //          
        if (currentDelay >= delay)                    //
        {                                             //
            currentDelay = 0;                         //
        }                                             //
    }

    void Spawn()
    {
        fireCube = true;                                                                              //
        cubeFired = Instantiate(spawndCube, spawnPoint.transform.position, Quaternion.identity);      //Instantiate the cubes
        cubeFired.transform.rotation = transform.rotation;                                            //
    }
}
