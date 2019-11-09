using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public int colorValue;
    BallsyForce ballsyForce;
    float timer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 15)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Cannon")
        {
            var renderer = gameObject.GetComponent<Renderer>();
            ballsyForce = other.gameObject.GetComponent<BallsyForce>();
            colorValue = ballsyForce.colorValue;

            switch (colorValue)
            {
                case 1:
                    renderer.material.SetColor("_Color", Color.red);
                    break;
                case 2:
                    renderer.material.SetColor("_Color", Color.yellow);
                    break;
                case 3:
                    renderer.material.SetColor("_Color", Color.blue);
                    break;
            }
        }
    }
}
