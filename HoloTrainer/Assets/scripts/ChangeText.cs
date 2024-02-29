using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{ 
    public TextMeshPro textMeshPro;
    int value;

    void Start()
    {
        
        if (textMeshPro == null)
        {
            UnityEngine.Debug.LogError("TextMeshPro reference not set in VariableValueDisplay script on GameObject: " + gameObject.name);
        }
        else
        {
            value = CollisionDetection.number_target;
            UpdateText(value);
        }
    }

    void Update()
    {
        if (textMeshPro != null && GameObject.Find("Sphere").GetComponent<Renderer>().enabled) {
            value = CollisionDetection.number_target;
            UpdateText(value);
        }
    }

    // Update the text when the variable value changes
    void UpdateText(int value)
    {
        if (textMeshPro != null)
        {
            textMeshPro.text = "The test is finished\nYour score was: " + value;
        }
    }
}
