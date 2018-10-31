using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMove : MonoBehaviour {

    public GameObject exploid;
    int k;
    [SerializeField]
    private float speed = 1f;
    [SerializeField]
     private AudioClip exploid_audio;
    private AudioSource shootaudio;
   public  GameObject tower, bullet, startstvol;
    public float time = 3f;
    
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            k = k + 1;
            if (k == 3)
            {
                Instantiate(exploid, GetComponent<Rigidbody>().position, GetComponent<Rigidbody>().rotation);

                Destroy(other.gameObject);
                Destroy(gameObject);
                Destroy_exploid();
                Destroy(GameObject.Find("bullet(Clone)"), 0f);
            }
        }

        if (other.tag == "Player")
        {
            Fire();
        }
        }

    private void Destroy_exploid()
    {
        Destroy(GameObject.Find("Pyroclastic Puff(Clone)"), 1f);

    }

    void Update()
    {

        transform.Translate(-Vector3.forward * 1 * Time.deltaTime * speed);
        tower.transform.Rotate(0, 0, 0.04f);
        if (Input.GetKeyDown(KeyCode.X))
        {
            Fire();
        }
      
    }

   

        public void Fire()
    {
        Vector3 spawnpoint = startstvol.transform.position;
        Quaternion spawnroot = startstvol.transform.rotation;
        GameObject fire_bullet = Instantiate(bullet, spawnpoint, spawnroot) as GameObject;
        Rigidbody run = fire_bullet.GetComponent<Rigidbody>();
        run.AddForce(fire_bullet.transform.forward * 100, ForceMode.Impulse);
    }
}
