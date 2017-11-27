using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// ES DE PRUEBA //

	private float speed = 10.0f;
	private Rigidbody2D rbg;

	void Start(){

		rbg = GetComponent<Rigidbody2D>();

	}


	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, moveVertical) * 5.0f;

		rbg.AddForce (movement * speed);
	}
}
