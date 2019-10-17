using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplittedSpawn : MonoBehaviour
{
    int forceDir;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        var renderer = gameObject.GetComponent<Renderer>();

        forceDir = Random.Range(1, 5);
        switch(forceDir)
        {
            case 1:
                renderer.material.SetColor("_Color", Color.red);
                rigidbody.AddForce(-100, 800, -200);

                print("red");
                break;
            case 2:
                renderer.material.SetColor("_Color", Color.black);
                rigidbody.AddForce(0, -100, -1000);

                print("black");
                break;
            case 3:
                renderer.material.SetColor("_Color", Color.blue);
                rigidbody.AddForce(-300, 200, -200);
                
                print("blue");
                break;
            case 4:
                renderer.material.SetColor("_Color", Color.yellow);
                rigidbody.AddForce(100, 300, -400);
               
                print("yellow");
                break;
        }
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 3)
        {
            Destroy(gameObject);
        }
    }
}
