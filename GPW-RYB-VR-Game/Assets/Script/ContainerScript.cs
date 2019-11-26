using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerScript : MonoBehaviour
{
    int redContainer = 1;
    int yellowContainer = 2;
    int blueContainer = 3;
    int ground = 4;
    int thisContainer;

    public ScoreScript scoreScript;
    
    BallScript ballScript;

    private void Start()
    {
        switch (name)                                   //
        {                                               //
            case "RedContainer":                        //
                thisContainer = redContainer;           //
                print(name + thisContainer);            //
                break;                                  //
            case "YellowContainer":                     //
                thisContainer = yellowContainer;        //
                print(name + thisContainer);            //Checks which object the class instance is attached to by name
                break;                                  //and assigns a value per container colour
            case "BlueContainer":                       //
                thisContainer = blueContainer;          //
                print(name + thisContainer);            //
                break;                                  //
            default:                                    //
                thisContainer = ground;                 //
                print(name + thisContainer);            //
                break;                                  //
        }                                               //
        scoreScript.score = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CannonBall")                                          //
        {                                                                       //
            ballScript = other.gameObject.GetComponent<BallScript>();           //
            if (tag == "Ground")                                                //
            {                                                                   //
                if (scoreScript.score >= 1)                                     //
                {                                                               //
                    scoreScript.score--;                                        //
                }                                                               //
            }                                                                   //
            else if (tag == "Container")                                        //
            {                                                                   //
                if (ballScript.colorValue == thisContainer)                     //When a ball/creature/throwable object is thrown into 
                {                                                               //a container, check the colour values and assign score 
                    scoreScript.score++;                                        //accordingly; it is done so that is never gets to a 
                }                                                               //negative value
                else if (ballScript.colorValue != thisContainer)                //
                {                                                               //then destroy the object
                    if (scoreScript.score == 1)                                 //
                    {                                                           //
                        scoreScript.score--;                                    //
                    }                                                           //
                    else if (scoreScript.score > 1)                             //
                    {                                                           //
                        scoreScript.score -= 2;                                 //
                    }                                                           //
                }                                                               //
                Destroy(other.gameObject);                                      //
            }                                                                   //
        }                                                                       //
    }                                                                           //
}
