﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorSpawn : MonoBehaviour
{

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
    void Update()
    {
        if (currentDelay == 0)
        {
            Fire();
        }

        if (fireCube && currentDelay < delay)
        {
            currentDelay += 1 * Time.deltaTime;
        }

        if (currentDelay >= delay)
        {
            currentDelay = 0;
        }

        /*if (Input.GetKeyDown(KeyCode.R))
        {

            Instantiate(spawndCube, spawnPoint.transform.position, Quaternion.identity);
        }*/
    }

    void Fire()
    {
        fireCube = true;
        cubeFired = Instantiate(spawndCube, spawnPoint.transform.position, Quaternion.identity);
        cubeFired.transform.rotation = transform.rotation;
    }
}
