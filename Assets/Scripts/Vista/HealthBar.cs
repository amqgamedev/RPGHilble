using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour {

	public Sprite[] hearts;


	// Use this for initialization
	void Start () {
		
		Damage (10);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Damage(int pos){

		this.GetComponent <Image>().sprite = hearts [pos];

	}
	
}
