using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splitter : MonoBehaviour
{
    public float destructionTimer;
    public bool launched;
    float startTimer;
    public int splitCase;
    public GameObject splittedPrefab;
    

    // Start is called before the first frame update
    void Start()
    {

    }
    
    public void Split()
    {
        switch(splitCase)
        {
            case 1:
                Instantiate(splittedPrefab, transform.position, Quaternion.identity);
                break;
            case 2:
                Instantiate(splittedPrefab, transform.position, Quaternion.identity);
                Instantiate(splittedPrefab, transform.position + new Vector3(0,2,0), Quaternion.identity);
                break;
            case 3:
                Instantiate(splittedPrefab, transform.position, Quaternion.identity);
                Instantiate(splittedPrefab, transform.position + new Vector3(0, 2, 3), Quaternion.identity);
                Instantiate(splittedPrefab, transform.position + new Vector3(3, 4, 0), Quaternion.identity);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (launched)
        {
            startTimer += Time.deltaTime;
            if(startTimer >= destructionTimer)
            {
                splitCase = Random.Range(1, 4);
                Split();
                launched = false;
                Destroy(gameObject);
                
            }
        }
    }
}
