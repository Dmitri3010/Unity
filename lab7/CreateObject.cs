using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour {

    Vector3 min, max, center;
    Vector3 cubevector;
    float ObjectHeight, ObjectX, ObjectZ;
    int angle=1;
    


	void Start ()
    {
        var rend = gameObject.GetComponent<MeshRenderer>();
        min = rend.bounds.min;
        max = rend.bounds.max;
        center = rend.bounds.center;
        ObjectHeight = gameObject.transform.position.y + 15;

	}
	
	
	void Update ()
    {
        ObjectX = Random.Range(min.x, max.x);
        ObjectZ = Random.Range(min.z, max.z);

        if (Input.GetKeyDown(KeyCode.Space))
            
        {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubevector = new Vector3(ObjectX, ObjectHeight, ObjectZ);
            cube.transform.localScale = new Vector3(7.5f, 7.5f, 7.5f);
            cube.transform.position = cubevector;
            cube.AddComponent<Rigidbody>();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            
            transform.Rotate(0, 0, +angle);
           
        }

        if (Input.GetKeyDown(KeyCode.S))
        {

            transform.Rotate(0, 0, -angle);
            
        }



    }
}
