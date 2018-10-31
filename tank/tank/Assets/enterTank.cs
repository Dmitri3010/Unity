using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterTank : MonoBehaviour
{
    public  Camera tankcam;
    public static bool enter;

    void Start()
    {
        enter = false;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F) && !enter)
            {
                enter = true;
                tankcam.gameObject.SetActive(true);
                Invoke ("Deligate", 2f);
                other.gameObject.SetActive(false);
                GetComponent<TankMove>().enabled = true;
            }
        }

    }

    void Deligate()
    {
        tankcam.GetComponent<ExitTank>().enabled = true;
    }
}
