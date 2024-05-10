using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
// Quits the player when the user hits escape
// Sourced from: https://docs.unity3d.com/ScriptReference/Application.Quit.html
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
