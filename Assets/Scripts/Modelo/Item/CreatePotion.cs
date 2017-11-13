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

		newPotion.ItemID = Random.Range(1,10);
		// stats del arma

		newPotion.Hp = 10;
	}

	public void strengthPotion(){
		newPotion = new PotionBase();
		
		newPotion.PotionType = PotionBase.PotionTypes.STRENGTH;
		// asignar el nombre del arma

		newPotion.ItemName = "Strength Potion";
		//descripcion del item
		newPotion.ItemDescription = "More Strength";		
		// id del weapon

		newPotion.ItemID = Random.Range(1,10);
		// stats del arma

		newPotion.Strength = 5;
	}

	public void intellectPotion(){
		newPotion = new PotionBase();
		
		newPotion.PotionType = PotionBase.PotionTypes.INTELLIGENCE;
		// asignar el nombre del arma

		newPotion.ItemName = "Intelligence Potion";
		//descripcion del item
		newPotion.ItemDescription = "More Intelligence";		
		// id del weapon

		newPotion.ItemID = Random.Range(1,10);
		// stats del arma

		newPotion.Intelligence = 5;
	}

	public void endurancePotion(){
		newPotion = new PotionBase();
		
		newPotion.PotionType = PotionBase.PotionTypes.ENDURANCE;
		// asignar el nombre del arma

		newPotion.ItemName = "Endurance Potion";
		//descripcion del item
		newPotion.ItemDescription = "More Endurance";		
		// id del weapon

		newPotion.ItemID = Random.Range(1,10);
		// stats del arma

		newPotion.Endurance = 5;
	}
}
