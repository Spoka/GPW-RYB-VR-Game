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
        if (name =="RedContainer")
        {
            thisContainer = redContainer;
            print(name + thisContainer);
        }
        else if (name == "YellowContainer")
        {
            thisContainer = yellowContainer;
            print(name + thisContainer);
        }
        else if (name == "BlueContainer")
        {
            thisContainer = blueContainer;
            print(name + thisContainer);
        }
        else if (tag == "Ground")
        {
            thisContainer = ground;
            print(name + thisContainer);
        }
        scoreScript.score = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CannonBall")
        {
            ballScript = other.gameObject.GetComponent<BallScript>();
            if (ballScript.colorValue == thisContainer)
            {
                scoreScript.score++;
            }
            else if (ballScript.colorValue != thisContainer)
            {
                if (thisContainer == ground)
                {
                    if (scoreScript.score >= 1)
                    {
                        scoreScript.score--;
                    }
                }
                else
                {
                    if (scoreScript.score == 1)
                    {
                        scoreScript.score--;
                    }
                    else if (scoreScript.score > 1)
                    {
                        scoreScript.score -= 2;
                    }
                }
            }
        }
    }
}
