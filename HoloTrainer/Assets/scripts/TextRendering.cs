using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextRendering : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("Sphere").GetComponent<Renderer>().enabled) 
        {
            GameObject.Find("Cube").GetComponent<Renderer>().enabled = false;
            GameObject.Find("Indicator").GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<Renderer>().enabled = true;
            CollisionDetection.number_target = 0;
        }
    }
}
