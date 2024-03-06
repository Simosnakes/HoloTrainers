using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

/** class for collision detection
*/
public class CollisionDetection : MonoBehaviour
{
    public int number_target = 0;//number of times the sphere collided with the cube

    /** OnTriggerEnter is called every time a collision happens
    * checks if the cube (with tag "target") is colliding
    */
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "target")
        {
            FlashSphere.entered = true;
            number_target++;
        }
    }
}
