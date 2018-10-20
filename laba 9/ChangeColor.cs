using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	void OnCollisionEnter(Collision col)
    {
        Color newcolor = new Color(1, 0, 0);
        Color newcolor1 = new Color(1, 1, 0);
        Color newcolor2 = new Color(1, 0, 1);
        Color newcolor3 = new Color(1, 1, 0);



        if (col.gameObject.name == "cube1")
        {
            col.gameObject.GetComponent<Renderer>().material.color = newcolor;
        }
        if (col.gameObject.name == "cube2")
        {
            col.gameObject.GetComponent<Renderer>().material.color = newcolor1;
        }
        if (col.gameObject.name == "cube3")
        {
            col.gameObject.GetComponent<Renderer>().material.color = newcolor2;
        }
        if (col.gameObject.name == "cube4")
        {
            col.gameObject.GetComponent<Renderer>().material.color = newcolor3;
        }

       
    }
}
