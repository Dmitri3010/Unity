using UnityEngine;

[RequireComponent (typeof (Rigidbody))]

public class moveplayer : MonoBehaviour {


    private Camera cam;
    private Rigidbody rb;

    private Vector3 velocity= Vector3.zero;
    private Vector3 rotation = Vector3.zero;
    private Vector3 camrotation = Vector3.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;

    }

    public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }

    public void Rotate(Vector3 _rotation)
    {
        rotation = _rotation; ;
    }

    public void RotateCam(Vector3 _camrotation)
    {
        camrotation = _camrotation; ;
    }

    public void FixedUpdate()
    {
        PerforMove();
        PerformRotation();

    }

    void PerforMove()
    {
        if (velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
    }

    void PerformRotation()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));
        if(cam != null)
        {
            cam.transform.Rotate(-camrotation);
        }
    }

}
