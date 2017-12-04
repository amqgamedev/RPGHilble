using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {

	public float speed = 10.0f;
	public ControlJoystick joystick;
	public Vector3 dir;	
	public Vector3 move {set; get;}
	private Rigidbody2D RGB;

	// Use this for initialization
	void Start () {

		RGB = gameObject.GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {

		move = PoolInput();

		MovePJ();
		
	}

	void MovePJ(){

		RGB.AddForce((move * speed));

	}

	private Vector3 PoolInput(){

	 dir = Vector3.zero;

			dir.x = joystick.Horizontal();
			dir.y = joystick.Vertical();

		if(dir.magnitude > 1)
			dir.Normalize();

		return dir;
	}
}
