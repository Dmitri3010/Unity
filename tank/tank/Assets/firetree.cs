using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firetree : MonoBehaviour {

    public GameObject fire;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {

            Instantiate(fire, GetComponent<Rigidbody>().position, GetComponent<Rigidbody>().rotation);
                Destroy(GameObject.Find("bullet(Clone)"), 0f);
            
        }

    }
}
