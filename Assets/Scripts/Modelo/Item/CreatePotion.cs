using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePotion : MonoBehaviour {
	private PotionBase newPotion;
	// Use this for initialization
	void Start () {
		
	}
	
	public void hpPotion(){
		newPotion = new PotionBase();
		
		newPotion.PotionType = PotionBase.PotionTypes.HEALTH;
		// asignar el nombre del arma

		newPotion.ItemName = "Heatlh Potion";
		//descripcion del item
		newPotion.ItemDescription = "Heals you";		
		// id del weapon

		newPotion.ItemValue = Random.Range(1,10);
		// stats del arma

		newPotion.Hp = 10;
	}
}
