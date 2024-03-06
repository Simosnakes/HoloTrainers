using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

//class for teleporting sphere
public class FlashSphere : MonoBehaviour
{
    // Start is called before the first frame update -100 +100, -50 +50
    public Stopwatch stopwatch;//measures time between teleports
    public Stopwatch stopwatch1; //measures execution time
    private const long DURATION = 3000L; //time between 2 teleports
    private const double MIN_X = 0, MAX_X = 1.5, MIN_Y = 1.3, MAX_Y = 2.2; //random ranges
    public bool entered = false;
    private double min_x;
    private double min_y;
    private double max_x;
    private double max_y; //limits of random
    private const long EXE_TIME = 35000L;

    /**Start is called before the first frame update
    *it starts the stopwatches and assigns the random limits
    */
    void Start()
    {
        stopwatch = Stopwatch.StartNew();
        min_x = transform.position.x + MIN_X;
        min_y = transform.position.x + MIN_Y;
        max_x = transform.position.x + MAX_X;
        max_y = transform.position.x + MAX_Y;

        stopwatch1 = Stopwatch.StartNew();

    }

    /** Update is called once per frame
    * Calls flash_sphere
    */
    void Update()
    {
        flash_sphere();
    }

    /**flash sphere teleports the ball to a random location every 5 seconds and
    * checks if the game hasnt finished yet
    */
    void flash_sphere()
    {
        
        if (stopwatch.ElapsedMilliseconds >= DURATION || entered)
        {
            float posx = Random.Range((float)min_x, (float)max_x);
            float posy = Random.Range((float)min_y, (float)max_y);
            stopwatch.Restart();
            gameObject.transform.position = new Vector3(posx, posy, gameObject.transform.position.z);
            entered = false;
        }
        if (stopwatch1.ElapsedMilliseconds >= EXE_TIME)
        {
            stopwatch.Stop();
            gameObject.GetComponent<Renderer>().enabled = false;
        }

    }
}
