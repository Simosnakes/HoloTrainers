using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Security.Cryptography;
using UnityEngine;

public class FixedMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform[] points;
    [SerializeField] int index;
    public static Stopwatch stopwatch;
    void Start()
    {
        stopwatch = Stopwatch.StartNew();
    }

    // Update is called once per frame
    void Update()
    {

        if (!gameObject.GetComponent<Renderer>().enabled)
        {
            stopwatch.Stop();
            //print(stopwatch.ElapsedMilliseconds);
        }
    }
}
