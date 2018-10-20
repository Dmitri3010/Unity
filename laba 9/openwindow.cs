using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openwindow : MonoBehaviour {

    bool open_window=false;

    float radius = 0.1f;


    public void Open()
    {
        if (open_window)
        {
            transform.Rotate(0, -90, 0);
            open_window = true;
        }

        else
        {
            transform.Rotate(0, 90, 0);
            open_window = false;
        }
    }

    void Update()
    {
           

        if (Input.GetKey(KeyCode.R))
        {
            Open();

            
        }
        
    }
}
