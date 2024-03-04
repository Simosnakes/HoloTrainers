using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Security.Cryptography;
using UnityEngine;

public class FixedMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform[] points;//array of points filled in Unity
    //[SerializeField] is required to assign values in Unity
    [SerializeField] int index;//index initialized at 0 in Unity
    public static Stopwatch stopwatch;
    /** Start is called before the first frame update
    * it starts a new stopwatch
    */
    void Start()
    {
        stopwatch = Stopwatch.StartNew();
    }

    /** Update is called once per frame
    */
    void Update()
    {

        if (!gameObject.GetComponent<Renderer>().enabled)
        {
            stopwatch.Stop();
        }
    }
}
