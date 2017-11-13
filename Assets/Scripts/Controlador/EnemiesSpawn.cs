using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawn : MonoBehaviour {

		public Transform enemy;																	//Prefab del enemigo


		
		void Start()
		{
			InvokeRepeating("spawnEnemy",2f, 3f);												//Tiempo de spawn

			for (int i = 0; i < 1; i++){
				Instantiate(enemy, new Vector3(i * 1f,0,0), Quaternion.identity);				// Instancia 1 copia del prefab del enemigo
			}
		}

		void spawnEnemy(){
			Transform instance = Instantiate(enemy);
		}
}