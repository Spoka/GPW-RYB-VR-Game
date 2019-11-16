using System.Collections;
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
    public float xForceMin = -300;
    public float xForceMax = 300;
    public float yForce = 700;
    public float zForce = -1500;
    public int colorValue;
    bool shoot;
    float timer;
    

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    //THIS NEEDS TO BE MOVED TO ANOTHER SCRIPT
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
    //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "CannonBall")
        {
            //splitter = other.gameObject.GetComponent<Splitter>();
            rigidBalldy = other.attachedRigidbody;
            shoot = true;
          
            timer += Time.deltaTime;
            if (timer >= 0.5f)
            {
                //splitter.launched = true;
                float xForce = Random.Range(xForceMin, xForceMax);
                rigidBalldy.AddForce(new Vector3(xForce, yForce, zForce));
                rigidBalldy.useGravity = true;
                timer = 0;
            }
        }
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
