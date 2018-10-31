using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateXY : MonoBehaviour {
    
   public float k = 10f;
    public float  m= 20f;
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.rotation = Quaternion.Euler(k, 0, m); 
        k += 1;
        m += 5;

    }
}
