using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGetter : MonoBehaviour
{
    BallScript ballScript;
    public BallsyForce cannonScript;
    public GameObject octopiPrefab;
    public GameObject prefabLoc;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CannonBall")
        {
            ballScript = other.gameObject.GetComponent<BallScript>();
            cannonScript.colorValue = ballScript.colorValue;
            Instantiate(octopiPrefab, prefabLoc.transform.position, octopiPrefab.transform.rotation);
            Destroy(other.gameObject);
        }
    }
}
