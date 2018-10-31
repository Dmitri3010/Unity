using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(moveplayer))]


public class playercontroller : MonoBehaviour {
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float lookspeed = 2f;
   

    private moveplayer engine;

    void Start()
    {
        engine = GetComponent<moveplayer>();
    }

    void Update()
    {
        float xMov = Input.GetAxisRaw("Horizontal");
        float yMov = Input.GetAxisRaw("Vertical");

        Vector3 movHor = transform.right * xMov;
        Vector3 movVer = transform.forward * yMov;

        Vector3 velocity = (movHor + movVer).normalized * speed;

        engine.Move(velocity);

        float Yrot= Input.GetAxis("Mouse X");
        Vector3 rotation = new Vector3(0, Yrot, 0) * lookspeed;
        engine.Rotate(rotation);

        float Xrot = Input.GetAxis("Mouse Y");
        Vector3 camRotation = new Vector3(Xrot, 0, 0) * lookspeed;

        engine.RotateCam(camRotation);

    }

}
