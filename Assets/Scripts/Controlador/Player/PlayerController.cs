using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// ES DE PRUEBA //
<<<<<<< HEAD
	public Vector3 inputDirection;
	private float speed = 10.0f;
	[SerializeField]private Rigidbody2D rbg;
=======

	private float speed = 5.0f;
	public float health = 10.0f;
	private Rigidbody2D rbg;
>>>>>>> 3bc967559956a9c053fa45c391543feb9aa53885
	public GameObject bulletPref;				//Prefab del disparo de rango
	public Transform bulletSpawn;				//Desde donde va a disparar
	

	void Start(){

		rbg = GetComponent<Rigidbody2D>();

	}

	void Update(){

		if(Input.GetKeyDown(KeyCode.Space)){					//Tecla la cual va llamar a la funcion fire
			Fire();
		}
			rbg = GetComponent<Rigidbody2D>();

	}


	void FixedUpdate()
	{
		inputDirection.x = Input.GetAxis("Horizontal");								
		inputDirection.y = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3 (inputDirection.x, inputDirection.y) * 5.0f;

		rbg.AddForce (movement * speed);
	}

	void Fire(){

		GameObject bullet = Instantiate(bulletPref,bulletSpawn.position, bulletSpawn.rotation) as GameObject;				//	instancia el prefab de bullet
		bullet.GetComponent<Rigidbody2D>().AddForce(inputDirection.normalized * 5.0f, ForceMode2D.Impulse);					//  le da "movimiento"
		

		Destroy(bullet, 3.0f);																								// tiempo de vida
	}


<<<<<<< HEAD
	
=======
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
>>>>>>> 3bc967559956a9c053fa45c391543feb9aa53885
}