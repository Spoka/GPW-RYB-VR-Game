using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DunkerScript : MonoBehaviour
{
    BallScript ballScript;
    int dunkedColorValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ScoreChecker")
        {
            ballScript = other.gameObject.GetComponentInParent<BallScript>();
            if (ballScript.colorValue == 4)
            {
                dunkedColorValue = Random.Range(1, 4);
                ballScript.colorValue = dunkedColorValue;
                var renderer = other.gameObject.GetComponentInParent<Renderer>();
                switch (dunkedColorValue)
                {
                    case 1:                                                             //
                        renderer.material.SetColor("_Color", Color.red);                //
                        break;                                                          //
                    case 2:                                                             //Set colour value equal to the value passed
                        renderer.material.SetColor("_Color", Color.yellow);             //from the ColorGetter and assign material colour
                        break;                                                          //accordingly to the value
                    case 3:                                                             //
                        renderer.material.SetColor("_Color", Color.blue);               //
                        break;
                }
            }
        }
    }
}
