using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;
//	private Vector3 radius;

	void Start ()
	{
		offset /*= radius*/ = transform.position - player.transform.position;
	}

	void LateUpdate ()
	{
		transform.position = player.transform.position + offset;
		transform.Rotate (new Vector3(0.0f, Input.GetAxis("Horizontal") / 5, 0.0f));
	}
}
