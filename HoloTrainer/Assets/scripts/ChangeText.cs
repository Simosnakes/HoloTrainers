using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using TMPro;

/**class for updating and rendering text
*/
public class ChangeText : MonoBehaviour
{ 
    public TextMeshPro textMeshPro;//text attribute
    int value; //player's score

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
            //update value in case it exists
            value = CollisionDetection.number_target;
            UpdateText(value);
        }
    }

    /** Update is called once per frame
    */

    void Update()
    {
        if (textMeshPro != null && GameObject.Find("Sphere").GetComponent<Renderer>().enabled) {
            value = CollisionDetection.number_target;
            UpdateText(value);
        }
    }

    /** Update the text when the variable value changes
    */
    void UpdateText(int value)
    {
        if (textMeshPro != null)
        {
            textMeshPro.text = "The test is finished\nYour score was: " + value;
        }
    }
}
