using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{
    public int colorValue;
   
    // Start is called before the first frame update
    void Start()
    {
        var renderer = gameObject.GetComponent<Renderer>();                   //Get renderer component from the object
                                                                              //this is attached to
        colorValue = Random.Range(1, 4);                                      //
                                                                              //
        switch (colorValue)                                                   //
        {                                                                     //Set random value to colorValue and assign
            case 1:                                                           //renderer colour accordingly
                renderer.material.SetColor("_Color", Color.red);              //
                break;                                                        //
            case 2:                                                           //
                renderer.material.SetColor("_Color", Color.yellow);           //
                break;                                                        //
            case 3:                                                           //
                renderer.material.SetColor("_Color", Color.blue);             //
                break;                                                        //
        }                                                                     //
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
