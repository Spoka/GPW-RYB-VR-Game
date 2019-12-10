using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public int colorValue;
    BallsyForce cannonScript;
    float timer;
	Renderer renderer;
	
    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {
		timer += Time.deltaTime;
		if (timer >= 10)
		{
			renderer.material.SetColor("_Color", Color.black);
		}
		if (timer >= 20)
		{
			Destroy(gameObject);
		}
	}

	private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Cannon")                                                  //
        {                                                                           //Get renderer component from the object this
            cannonScript = other.gameObject.GetComponent<BallsyForce>();            //is attached to
            colorValue = cannonScript.colorValue;                                   //
                                                                                    //
            switch (colorValue)                                                     //
            {                                                                       //
                case 1:                                                             //
                    renderer.material.SetColor("_Color", Color.red);                //
                    break;                                                          //
                case 2:                                                             //Set colour value equal to the value passed
                    renderer.material.SetColor("_Color", Color.yellow);             //from the ColorGetter and assign material colour
                    break;                                                          //accordingly to the value
                case 3:                                                             //
                    renderer.material.SetColor("_Color", Color.blue);               //
                    break;                                                          //
            }                                                                       //
        }                                                                           //
		if (other.tag == "Ground")
		{
			timer += Time.deltaTime;   
			if (timer >= 3)            
			{                          
				Destroy(gameObject);   
			}                          
		}
		if (other.tag == "Container")
		{
			timer += Time.deltaTime;
			if (timer >= 10)
			{
				Destroy(gameObject);
				print("aaaaa" + timer);
			}
		}
    }
}
