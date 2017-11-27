 using UnityEngine;
 using System.Collections;
 using System.Collections.Generic;
 
 public class followEne : MonoBehaviour {
     
        public Transform target;            //fija un objetivo
        public float speed = 5f;             //velocidad
        private float range = 5f;           // rango del raycast
        private Vector3 targetDirection;


			void Start () {
   
           	target = GameObject.Find("Player").transform;                       					//busca al objetivo


             }


			void Update () {

   
               FollowP();

             }


			void FollowP () {

       			targetDirection = (target.position - transform.position).normalized * range;                 // direccion perseguir
            RaycastHit2D hit = Physics2D.Raycast(transform.position, targetDirection, range);           // Vision para que comienze a perseguir
          
            if (hit.collider != null) {
                if (hit.collider.CompareTag("Player")) {
                  Debug.Log("+.+");
                 transform.position += (targetDirection).normalized * speed * Time.deltaTime;
                }
        
            }
            

             }


             private void OnDrawGizmos() {
                Gizmos.color = Color.green;
                  Gizmos.DrawRay(transform.position, targetDirection);


    }

       
  }
 

     