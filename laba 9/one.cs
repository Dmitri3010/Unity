using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class one : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = gameObject.GetComponent<Transform>().position;
        Vector3 new_position = new Vector3(position.x+0.01f, position.y, position.z);
        transform.position = new_position; 
	}
}
