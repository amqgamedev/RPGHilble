using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCom : MonoBehaviour {

	public Transform bullet;
	

	// Use this for initialization
	void Start () {
		InvokeRepeating("BulletShot",3.0f,0f);
		

		for (int i = 0; i < 1; i++){
				Instantiate(bullet, new Vector3(i * 3f,0,0), Quaternion.identity);
			}
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		transform.Translate(Vector2.right * Time.deltaTime);		//cambiar por seguir al target
	}

	void BulletShot(){
		Transform instance = Instantiate(bullet);
	}

}
