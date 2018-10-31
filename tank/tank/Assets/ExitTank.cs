using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTank : MonoBehaviour {

    public GameObject player, spawn;
 

	void Update () {
       
                if (Input.GetKeyDown(KeyCode.F) && enterTank.enter)
                {
            Exit();
                }
    }

    public void Exit()
    {
        player.transform.position = spawn.transform.position;
        enterTank.enter = false;
        player.SetActive(true);
        gameObject.SetActive(false);
        transform.GetComponentInParent<TankMove>().enabled = false;
        enterTank.enter = false;
        this.enabled = false;
    }
}
