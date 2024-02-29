using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public static int number_target = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "target")
        {
            FlashSphere.entered = true;
            number_target++;
        }
    }
}
