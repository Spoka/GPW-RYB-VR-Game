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

    AudioSource audioSource;
    public AudioClip[] shootClips;
    
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
            audioSource = other.GetComponent<AudioSource>();
            shoot = true;                                                          //throwable object
                                                                                   //
            timer += Time.fixedDeltaTime;                                          //
            if (timer >= timeToShoot)                                              //After shoot delay, shoot the throwable object
            {                                                                      //by adding force in given directions set in editor
                Shoot();                                                           //and play a random audio clip among the ones set
                                                                                   //in editor
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

    void Shoot()
    {
        float xForce = Random.Range(-xForceRange, xForceRange);
        float yForce = Random.Range(yForceRange - 20, yForceRange + 20);
        float zForce = Random.Range(zForceRange - 80, zForceRange + 80);
        rigidBalldy.AddForce(new Vector3(xForce, yForce, -zForce));
        rigidBalldy.useGravity = true;
        int i = Random.Range(0, shootClips.Length);
        audioSource.PlayOneShot(shootClips[i]);
    }
    
    // Update is called once per frame
    void Update()
    {
        //THIS WAS USED TO TEST SHOOTING AND INSTANTIATION PRIOR TO THE ACTUAL CODE 
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
