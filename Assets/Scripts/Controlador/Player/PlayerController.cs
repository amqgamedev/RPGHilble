using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// ES DE PRUEBA //

	private float speed = 10.0f;
	private Rigidbody2D rbg;
	public GameObject bulletPref;				//Prefab del disparo de rango
	public Transform bulletSpawn;				//Desde donde va a disparar

	void Start(){

		rbg = GetComponent<Rigidbody2D>();

	}

	void Update(){

		if(Input.GetKeyDown(KeyCode.Space)){					//Tecla la cual va llamar a la funcion fire
			Fire();
		}
	}


	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");								
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, moveVertical) * 5.0f;

		rbg.AddForce (movement * speed);
	}

	void Fire(){

		var bullet = (GameObject)Instantiate(bulletPref,bulletSpawn.position, bulletSpawn.rotation);				//	
		bulletPref.GetComponent<Rigidbody2D>().velocity = bulletPref.transform.forward * 5.0f;						//


		Destroy(bullet, 3.0f);																						// tiempo de vida
	}
}
