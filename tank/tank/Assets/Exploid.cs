using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploid : MonoBehaviour {

    public GameObject exploid;

   private  void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {

            Instantiate(exploid, GetComponent<Rigidbody>().position, GetComponent<Rigidbody>().rotation);

            Destroy(other.gameObject);
            Destroy(gameObject);
            Destroy_exploid();
        }
              
    }

    private void Destroy_exploid()
    {
        Destroy(GameObject.Find("Pyroclastic Puff(Clone)"), 1f);
        
    }
}
