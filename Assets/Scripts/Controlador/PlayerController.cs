using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// ES DE PRUEBA //

	public float speed;
	private Rigidbody rbg;

	void Start(){

		rbg = GetComponent<Rigidbody>();

	}


	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		rbg.AddForce (movement * speed);
	}
}
