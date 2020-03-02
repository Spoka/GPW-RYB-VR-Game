using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGetter : MonoBehaviour
{
    ColorScript colorScript;
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

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Conveyed")
        {
            colorScript = other.gameObject.GetComponent<ColorScript>();                                   //Upon collision with a 
            cannonScript.colorValue = colorScript.colorValue;                                             //conveyed object, store
            Instantiate(octopiPrefab, prefabLoc.transform.position, octopiPrefab.transform.rotation);     //colour value and instantiate
            Destroy(other.gameObject);                                                                    //throwable object in cannon
        }
    }
}
