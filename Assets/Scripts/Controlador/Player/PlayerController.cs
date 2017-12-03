using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// ES DE PRUEBA //

	private float speed = 10.0f;
	public float health = 10.0f;
	private Rigidbody2D rbg;
	public GameObject bulletPref;				//Prefab del disparo de rango
	public Transform bulletSpawn;				//Desde donde va a disparar
	private Vector3 otherposition;
	

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
		Vector3 movement = new Vector3 (moveHorizontal, moveVertical) * 3.0f;

		rbg.AddForce (movement * speed);
	}

	void Fire(){

		var bullet = (GameObject)Instantiate(bulletPref,bulletSpawn.position, bulletSpawn.rotation);				//	
		bulletPref.GetComponent<Rigidbody2D>().velocity = bulletPref.transform.forward * 5.0f;						//


		Destroy(bullet, 3.0f);																						// tiempo de vida
	}


	void OnCollisionEnter2D(Collision2D other)
	{
		PlayerController takedamage = other.gameObject.GetComponent<PlayerController>();
		//rbg = other.gameObject.GetComponent<Rigidbody2D>();
		if (rbg != null) 
		{
			if(other.transform.CompareTag("Enemy"))
			{
				takedamage.health -= Random.Range(3f, 5f);

				otherposition = other.transform.position;
					Debug.Log("Tocandose");


					if(health <= 0)	
				{
					Debug.Log(this.name + "ddddestroy");
					Destroy(this.gameObject);
				}

			}
		}
	}
}