using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawn : MonoBehaviour {

		public Transform enemy;																	//Prefab del enemigo
		private int enemyCount;
		public int maxEC;


		
		void Start()
		{
			InvokeRepeating("spawnEnemy",5f, 3f);												//Tiempo de spawn

			for (int i = 0; i < 1; i++){
			}
		}

		void spawnEnemy(){

			enemyCount++;
			if(enemyCount>=maxEC){
				CancelInvoke("spawnEnemy");														// Para el spawn
			}																					// Arreglar a que spawn se reactive hasta una cierta cantidad.

			Instantiate(enemy, transform.position, Quaternion.identity);				

		}
}