using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorSpawn : MonoBehaviour
{

    public GameObject spawnPoint;
    public GameObject spawndCube;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(spawndCube, spawnPoint.transform.position, Quaternion.identity);
        }
    }
}
