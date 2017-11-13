 using UnityEngine;
 using System.Collections;
 
 public class followEne : MonoBehaviour {
     
        public Transform target;            //fija un objetivo
        public float speed = 1;             //velocidad

         void Start () {
   
           target = GameObject.Find("Player").transform;                       //busca al objetivo

             }

         void Update () {
   
               FollowP();

             }

  
  
        void FollowP () {
        Vector3 targetDirection = target.position - transform.position;
        transform.position += targetDirection * speed * Time.deltaTime;
             }
}
     