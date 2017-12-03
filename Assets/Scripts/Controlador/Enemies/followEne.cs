 using UnityEngine;
 using System.Collections;
 using System.Collections.Generic;
 
 public class followEne : MonoBehaviour {
     
        public Transform target;            //fija un objetivo
        public float speed = 5f;             //velocidad
        private float range = 5f;           // rango del raycast
        public float health = 20;
        private Vector3 targetDirection;
        private Vector3 otherposition;
        private Rigidbody2D rbg;


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

              void OnCollisionEnter2D(Collision2D other){
	            	followEne takedamage = other.gameObject.GetComponent<followEne>();
	            	rbg = other.gameObject.GetComponent<Rigidbody2D>();
	            	if (rbg != null) {
		          	if(other.transform.CompareTag("Player")){
		        		takedamage.health -= Random.Range(3f, 5f);

		        		otherposition = other.transform.position;
			      		Debug.Log("Tocandose");

		
			}
		}
	}  

       
  }
 

     