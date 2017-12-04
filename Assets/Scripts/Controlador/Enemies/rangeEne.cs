using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangeEne : MonoBehaviour {
	

	public Transform target;            //fija un objetivo
	private float range = 5f;           // rango del raycast
	private Vector3 targetDirection;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	//	InvokeRepeating("FireEne",3.0f,3.0f);

	FollowP();

	}


		void FollowP () {

       		targetDirection = (target.position - transform.position).normalized * range;                 // direccion perseguir
            RaycastHit2D hit = Physics2D.Raycast(transform.position, targetDirection, range);           // Vision para que comienze a perseguir
          
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
