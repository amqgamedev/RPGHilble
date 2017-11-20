 using UnityEngine;
 using System.Collections;
 using System.Collections.Generic;
 
 public class followEne : MonoBehaviour {
     
        public Transform target;            //fija un objetivo
        public float speed = 1;             //velocidad
		public float health = 10f;			// vida
		private Rigidbody rgb;				// para detectar en la colision


			void Start () {
   
           	target = GameObject.Find("Player").transform;                       					//busca al objetivo

             }


			 

			void Update () {
   
               FollowP();

             }

			void OnCollisionEnter(Collision other){													// recivir y hacer damage
					followEne takedamage = other.gameObject.GetComponent<followEne>();
					rgb = other.gameObject.GetComponent<Rigidbody>();

			 }

  
  
  			void FollowP () {

       			 Vector3 targetDirection = target.position - transform.position;
       			 transform.position += targetDirection * speed * Time.deltaTime;

             }

       
  }
 

     