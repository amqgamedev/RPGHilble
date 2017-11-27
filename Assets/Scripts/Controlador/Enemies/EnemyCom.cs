using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCom : MonoBehaviour {

	public GameObject bullet;
	private Transform bulletSpawn;
	private float speed = 1f;

	

	void Start () {
		InvokeRepeating("BulletShot",3.0f,0f);
		

		for (int i = 0; i < 1; i++){
				Instantiate(bullet, new Vector3(i * 3f,0,0), Quaternion.identity);
			}
		
	}
	
	void Update () {
		
		
	}

	void BulletShot(){
		GameObject instance = Instantiate(bullet);

		
		}
	}

