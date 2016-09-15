using UnityEngine;
using System.Collections;
/*
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
}*/
public class PlayerController : MonoBehaviour{
	public float movementSpeed = 10;
	public GameObject player;

	void Update(){
		if (Input.GetKey (KeyCode.UpArrow)) {
			Move (Vector3.left);
		}
	}
	void Move(Vector3 direction){
		var newDirection = Quaternion.LookRotation (Camera.main.transform.position - transform.position);
		newDirection.x = 0;
		newDirection.z = 0;
		player.transform.rotation = Quaternion.Euler (newDirection);
		transform.Translate (-direction * Time.deltaTime * movementSpeed, player.transform);
	}
}
