using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : StatItemBase { // hereda los stats de los items

	public enum WeaponTypes{
		SWORD,
		STAFF,
		
	}

	private WeaponTypes weaponTypes;

	public WeaponTypes WeaponType{
		get{return weaponTypes;}
		set{weaponTypes = value;}
	}
}
