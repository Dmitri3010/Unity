using UnityEngine;

public class Rotate : MonoBehaviour
{
	public float speedH = 10f;
	public float speedV = 10f;

	private float yaw = 0f;
	private float pitch = 0f;

	void Update()
	{
		yaw += speedH * Input.GetAxis("Mouse X");
		pitch -= speedV * Input.GetAxis("Mouse Y");

		transform.eulerAngles = new Vector3(Mathf.Clamp(pitch, -45f, 0f), yaw, 0f);
	}
}