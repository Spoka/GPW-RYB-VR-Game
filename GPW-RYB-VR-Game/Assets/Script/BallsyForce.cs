using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BallsyForce : MonoBehaviour
{
    Rigidbody rigidBalldy;
    Splitter splitter;
    public GameObject ballsyPrefab;
    public GameObject prefabLoc;
    public float hTravel = 700;
    public float lTravel = -1500;
    bool shoot;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "CannonBall")
        {
            splitter = other.gameObject.GetComponent<Splitter>();
            rigidBalldy = other.attachedRigidbody;
            shoot = true;
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
    }
}
