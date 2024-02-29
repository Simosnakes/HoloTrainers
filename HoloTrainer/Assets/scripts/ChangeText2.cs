using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using TMPro;

public class ChangeText2 : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    long value;

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

    void Update()
    {
        if (textMeshPro != null && GameObject.Find("Sphere").GetComponent<Renderer>().enabled)
        {
            value = FixedMovement.stopwatch.ElapsedMilliseconds / 1000;
            UpdateText(value);
        }
    }

    // Update the text when the variable value changes
    void UpdateText(long value)
    {
        if (textMeshPro != null)
        {
            textMeshPro.text = "The test is finished\nYour time was: " + value;
        }
    }
}
