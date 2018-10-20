using UnityEngine;

public class Move : MonoBehaviour
{
	public Light DoorLight;
	public Light GreenLight;
	public float Speed = 50f;

	void OnTriggerEnter(Collider collider)
	{
		if (collider.name == "Trigger")
			DoorLight.enabled = true;
		else if (collider.name == "Trigger2")
			GreenLight.color = Color.red;
	}

	void OnTriggerExit(Collider collider)
	{
		if (collider.name == "Trigger")
			DoorLight.enabled = false;
		else if (collider.name == "Trigger2")
			GreenLight.color = Color.green;
	}

	void Awake()
	{
		Cursor.visible = false;
		GreenLight.color = Color.green;
	}

	void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.W))
			transform.Translate(Vector3.forward * Speed * Time.deltaTime);
		if (Input.GetKey(KeyCode.S))
			transform.Translate(Vector3.back * Speed * Time.deltaTime);
		if (Input.GetKey(KeyCode.Q))
			transform.Translate(Vector3.left * Speed * Time.deltaTime);
		if (Input.GetKey(KeyCode.D))
			transform.Translate(Vector3.right * Speed * Time.deltaTime);
	}
}