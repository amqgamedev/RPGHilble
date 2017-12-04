using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangeEne : MonoBehaviour {
	
	public GameObject bulletPref;
	public Transform bulletSpawn;
	public Transform target;            //fija un objetivo
	private float range = 5f;           // rango del raycast
	private Vector3 targetDirection;
	private Vector3 inpDirection;

	private float timer = 0;
	
	private float rateOfFire = 3f;
	RaycastHit2D hit;
	public float bulletSpeed = 5f;

	void Start () {
		
	}
	
	void Update () {

		timer += Time.deltaTime;
		if(timer > rateOfFire && hit == true){																					
			GameObject bullet = Instantiate(bulletPref,bulletSpawn.position, bulletSpawn.rotation) as GameObject;			//instanciar la bala
			bullet.GetComponent<Rigidbody2D>().AddForce( inpDirection.normalized * 5.0f, ForceMode2D.Impulse);				//darle una fuerza
			bullet.GetComponent<Rigidbody2D>().AddForce(targetDirection.normalized * bulletSpeed, ForceMode2D.Impulse);
			bullet.GetComponent<BulletScript>().isEnemy = true;																//el prefab de la bala solo choque contra el player
			timer = 0;
		}
	

	FollowP();

	}


		void FollowP () {

       		targetDirection = (target.position - transform.position).normalized * range;                 // Direccion perseguir
            hit = Physics2D.Raycast(transform.position, targetDirection, range);          				 
          
            if (hit.collider != null) {
                if (hit.collider.CompareTag("Player")) {
					
                  Debug.Log("++");
                }
        
         }
}



			private void OnDrawGizmos() {
                Gizmos.color = Color.red;
                  Gizmos.DrawRay(transform.position, targetDirection);


    }
}
