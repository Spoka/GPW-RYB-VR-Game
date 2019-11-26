﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BallsyForce : MonoBehaviour
{
    Rigidbody rigidBalldy;
    //Splitter splitter;
    //ColorScript colorScript;
    //public GameObject ballsyPrefab;
    //public GameObject prefabLoc;
    public float xForceMin = -300;          //
    public float xForceMax = 300;           //All shoot forces can be set from the editor
    public float yForce = 700;              //
    public float zForce = -1500;            //
    public float timeToShoot = 1;
    public int colorValue;
    bool shoot;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }
    
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Conveyed")
    //    {
    //        colorScript = other.gameObject.GetComponent<ColorScript>();
    //        colorValue = colorScript.colorValue;
    //        Instantiate(ballsyPrefab, prefabLoc.transform.position, ballsyPrefab.transform.rotation);
    //        Destroy(other.gameObject);
    //    }
    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "CannonBall")                                             //
        {                                                                          //
            //splitter = other.gameObject.GetComponent<Splitter>();                //
            rigidBalldy = other.attachedRigidbody;                                 //Get rigidbody component from the colliding 
            shoot = true;                                                          //throwable object
                                                                                   //
            timer += Time.deltaTime;                                               //
            if (timer >= timeToShoot)                                              //After shoot delay, shoot the throwable object
            {                                                                      //by adding force in given directions set in editor
                //splitter.launched = true;                                        //
                float xForce = Random.Range(xForceMin, xForceMax);                 //Y and Z forces are fixed, X is a set range value
                rigidBalldy.AddForce(new Vector3(xForce, yForce, zForce));         //
                rigidBalldy.useGravity = true;                                     //Then enable gravity for the throwable object
                timer = 0;                                                         //
            }                                                                      //
        }                                                                          //
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "CannonBall")
        {
            shoot = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space) && shoot)
        {
            splitter.launched = true;
            rigidBalldy.AddForce(new Vector3(0, hTravel, lTravel));
            rigidBalldy.useGravity = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && !shoot)
        {
            Instantiate(ballsyPrefab, prefabLoc.transform.position, ballsyPrefab.transform.rotation);
        }
        */
    }
}
