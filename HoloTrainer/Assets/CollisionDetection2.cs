using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class CollisionDetection2 : MonoBehaviour
{
    public static int number_target = 0;
    [SerializeField] Transform[] points;
    [SerializeField] int index;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "target")
        {
            number_target++;
            print(number_target);
            move_sphere();
        }
    }

    void move_sphere()
    {
        if ((index) <= points.Length + 1)
        {   
            if ((index) <= points.Length - 1)
                GameObject.Find("Sphere").transform.position = points[index].transform.position;
            if (index == points.Length)
                GameObject.Find("Sphere").transform.position = points[0].transform.position;
            index++;
            if ((index) >= points.Length + 2)
            {
                index = 0;
                GameObject.Find("Sphere").GetComponent<Renderer>().enabled = false;
            }
        }
    }
}
