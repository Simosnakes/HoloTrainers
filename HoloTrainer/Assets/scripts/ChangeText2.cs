using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using TMPro;

/**class for updating and rendering text
*/
public class ChangeText2 : MonoBehaviour
{
    public TextMeshPro textMeshPro;//text attribute
    long value;//player's score

    /** Start is called once before the first frame
    * Start checks the existence of the text
    */
    void Start()
    {

        if (textMeshPro == null)
        {
            UnityEngine.Debug.LogError("TextMeshPro reference not set in VariableValueDisplay script on GameObject: " + gameObject.name);
        }
        else
        {
            value = FixedMovement.stopwatch.ElapsedMilliseconds;
            UpdateText(value);
        }
    }

    /** Update is called once per frame
    */
    void Update()
    {
        if (textMeshPro != null && GameObject.Find("Sphere").GetComponent<Renderer>().enabled)
        {
            value = FixedMovement.stopwatch.ElapsedMilliseconds / 1000;
            UpdateText(value);
        }
    }

    /** Update the text when the variable value changes
    */
    void UpdateText(long value)
    {
        if (textMeshPro != null)
        {
            textMeshPro.text = "The test is finished\nYour time was: " + value;
        }
    }
}
