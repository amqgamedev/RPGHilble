using UnityEngine;

public class BulletScript : MonoBehaviour {

	[HideInInspector] public bool isEnemy = false; 				//modificarlo a true si la bala sale de un enemigo

	void OnTriggerEnter2D(Collider2D col){

		if(col.CompareTag("Enemy")){
			if(isEnemy == false){
				Destroy(col.gameObject);
				Debug.Log("hacerle danio al enemigo");
				
			}
		}
		else if(col.CompareTag("Player")){

			if(isEnemy == true){
//				 gameObject.GetComponent<CreateNewCharacter>().hp;
//				if(hp <= 0){
//				Debug.Log(this.name + "ddddestroy");
//				Destroy(this.gameObject);
				}

				Debug.Log("hacerle danio al player");
			}
		}
	}

