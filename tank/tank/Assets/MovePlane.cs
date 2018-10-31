using UnityEngine;

public class MovePlane : MonoBehaviour {

    [SerializeField]
    private float speed = 30f;
    [SerializeField]
    private AudioSource planeaudio;
    public GameObject rotate_engine;

    private AudioClip move_plane;

    void Update() {

        transform.Translate(-Vector3.right * 1 * Time.deltaTime * speed);
        rotate_engine.transform.Rotate(0,0, 20f);

    }


}


