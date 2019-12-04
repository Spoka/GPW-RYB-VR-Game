using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BallsyForce : MonoBehaviour
{
    Rigidbody rigidBalldy;
    
    //All shoot forces can be adjusted in editor
    [Range(0f, 500f)]
    public float xForceRange = 250;

    [Range(0f, 1000f)]
    public float yForceRange = 500;

    [Range(0f, 1000f)]
    public float zForceRange = 500;

    public float timeToShoot = 1;
    public int colorValue;
    bool shoot;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "CannonBall")                                             //
        {                                                                          //
            //splitter = other.gameObject.GetComponent<Splitter>();                //
            rigidBalldy = other.attachedRigidbody;                                 //Get rigidbody component from the colliding 
            AudioSource shootClip = other.GetComponent<AudioSource>();
            shoot = true;                                                          //throwable object
                                                                                   //
            timer += Time.deltaTime;                                               //
            if (timer >= timeToShoot)                                              //After shoot delay, shoot the throwable object
            {                                                                      //by adding force in given directions set in editor
                //splitter.launched = true;                                        //
                float xForce = Random.Range(-xForceRange, xForceRange);            //All force directions are ranges
                float yForce = Random.Range(yForceRange - 20, yForceRange + 20);   //X is a wide range, Y and Z are smaller ranges
                float zForce = Random.Range(zForceRange - 80, zForceRange + 80);   //
                rigidBalldy.AddForce(new Vector3(xForce, yForce, -zForce));        //
                rigidBalldy.useGravity = true;                                     //Then enable gravity for the throwable object
                shootClip.Play();
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
