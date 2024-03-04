using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

/**class for updating and rendering text
*/
public class CollisionDetection2 : MonoBehaviour
{
    public static int number_target = 0;//number of times the sphere collided with the cube
    //[SerializeField] is required to assign values in Unity
    [SerializeField] Transform[] points;//array of points filled in Unity
    [SerializeField] int index; //index initialized at 0 in Unity

    /** OnTriggerEnter is called every time a collision happens
    * checks if the cube (with tag "target") is colliding, if true, calls move_sphere
    */
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "target")
        {
            number_target++;
            print(number_target);
            move_sphere();
        }
    }

    /** move_sphere is called to move the sphere to the next coordinate
    */
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
