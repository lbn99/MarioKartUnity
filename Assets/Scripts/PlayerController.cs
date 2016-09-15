using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
//		Vector3 movement = new Vector3 (0.0f, 0.0f, moveVertical);

//		rb.AddRelativeForce (movement * speed);
//		gameObject.transform.Rotate (new Vector3 (0.0f, moveHorizontal, 0.0f) * Time.deltaTime * 20.0f);
		rb.AddForce(movement * speed);
	}
}
