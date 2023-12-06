using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasToggle : MonoBehaviour
{
    public Canvas canvas;
    public KeyCode toggleKey = KeyCode.I;

    void Start()
    {
        canvas.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            canvas.enabled = !canvas.enabled;
        }
    }
}
