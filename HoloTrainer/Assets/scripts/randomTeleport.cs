using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class FlashSphere : MonoBehaviour
{
    // Start is called before the first frame update -100 +100, -50 +50
    public Stopwatch stopwatch;
    public Stopwatch stopwatch1;
    private const long DURATION = 3000L;
    private const double MIN_X = 0, MAX_X = 1.5, MIN_Y = 1.3, MAX_Y = 2.2;
    public static bool entered = false;
    private double min_x;
    private double min_y;
    private double max_x;
    private double max_y;
    private const long TWENTY_SECONDS = 35000L;
    void Start()
    {
        stopwatch = Stopwatch.StartNew();
        min_x = transform.position.x + MIN_X;
        min_y = transform.position.x + MIN_Y;
        max_x = transform.position.x + MAX_X;
        max_y = transform.position.x + MAX_Y;

        stopwatch1 = Stopwatch.StartNew();

    }

    // Update is called once per frame
    void Update()
    {
        flash_sphere();
    }
    void flash_sphere()
    {
        
        if (stopwatch.ElapsedMilliseconds >= DURATION || entered)
        {
            float posx = Random.Range((float)min_x, (float)max_x);
            float posy = Random.Range((float)min_y, (float)max_y);
            //gameObject.GetComponent<Renderer>().enabled = !gameObject.GetComponent<Renderer>().enabled;
            stopwatch.Restart();
            gameObject.transform.position = new Vector3(posx, posy, gameObject.transform.position.z);
            entered = false;
        }
        //UnityEngine.Debug.Log(gameObject.transform.position);

        if (stopwatch1.ElapsedMilliseconds >= TWENTY_SECONDS)
        {
            stopwatch.Stop();
            gameObject.GetComponent<Renderer>().enabled = false;
        }

    }
}
