using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	

	private Vector3 inputDirection;
	
	[SerializeField]private Rigidbody2D rbg;
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


	void Fire(){

		GameObject bullet = Instantiate(bulletPref,bulletSpawn.position, bulletSpawn.rotation) as GameObject;								//	instancia el prefab de bullet
		bullet.GetComponent<Rigidbody2D>().AddForce(GetComponent<PlayerMotor>().dir.normalized * 5.0f, ForceMode2D.Impulse);				//  le da "movimiento"
		Debug.Log("Disparando");	
		

		Destroy(bullet, 3.0f);																								// tiempo de vida
	}

}