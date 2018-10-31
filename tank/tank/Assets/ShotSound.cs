using UnityEngine;

public class ShotSound : MonoBehaviour {

    private AudioSource shootaudio;

    void Start()
    {
        shootaudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shootaudio.Play();
        }
    }
}
