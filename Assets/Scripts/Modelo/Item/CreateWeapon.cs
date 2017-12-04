using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWeapon : MonoBehaviour {

	private WeaponBase newWeapon;
	
	
	void Start()
	{
		NewSword();
		NewStaff();
		
	}
	public void NewSword(){

		
		newWeapon = new WeaponBase();
		
		newWeapon.WeaponType = WeaponBase.WeaponTypes.SWORD;
		// asignar el nombre del arma

		newWeapon.ItemName = "Sword";
		//descripcion del item
		newWeapon.ItemDescription = "New Sword";		
		// id del weapon

		newWeapon.ItemValue = Random.Range(1,10);
		// stats del arma

		newWeapon.Endurance = Random.Range(5,10);
		newWeapon.Strength = Random.Range(5,15);
		newWeapon.Intelligence = Random.Range(0,2);		
		
		Debug.Log(newWeapon.ItemName);
		Debug.Log(newWeapon.ItemDescription);
		Debug.Log(newWeapon.ItemValue.ToString());	
		Debug.Log(newWeapon.Endurance.ToString());	
		Debug.Log(newWeapon.Strength.ToString());
		Debug.Log(newWeapon.Intelligence.ToString());
		
		
	}

	public void NewStaff(){
		newWeapon.WeaponType = WeaponBase.WeaponTypes.STAFF;
		// asignar el nombre del arma

		newWeapon.ItemName = "Staff";
		//descripcion del item
		newWeapon.ItemDescription = "New Staff";		
		// id del weapon

		newWeapon.ItemValue = Random.Range(1,10);
		// stats del arma

		newWeapon.Endurance = Random.Range(5,10);
		newWeapon.Strength = Random.Range(0,2);
		newWeapon.Intelligence = Random.Range(5,15);

		Debug.Log(newWeapon.ItemName);
		Debug.Log(newWeapon.ItemDescription);
		Debug.Log(newWeapon.ItemValue.ToString());	
		Debug.Log(newWeapon.Endurance.ToString());	
		Debug.Log(newWeapon.Strength.ToString());
		Debug.Log(newWeapon.Intelligence.ToString());
	}

	
		
}
