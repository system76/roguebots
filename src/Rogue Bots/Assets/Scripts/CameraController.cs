using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public float moveSpeed = 10f;
	public float turnSpeed = 50f;

	Ray ray;
	RaycastHit hit;


	// Use this for initialization
	void Start () {

	


	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W))
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.S))
			transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.A))
			transform.Translate (Vector3.left * moveSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.D))
			transform.Translate (Vector3.right * moveSpeed * Time.deltaTime);	

		checkHit ();

	}

	void checkHit() {
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (ray, out hit)) {
			Debug.Log (hit.collider.name);
		}
	}

}