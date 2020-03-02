using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    //public GameObject conBelt;
    public Transform endPoint;
    public float speed;

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerStay(Collider coll)
    {
        coll.transform.position = Vector3.MoveTowards(coll.transform.position, endPoint.position, speed * Time.deltaTime); //Move any object on collider towards end point
    }
}
