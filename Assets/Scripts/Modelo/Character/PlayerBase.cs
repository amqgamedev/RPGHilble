using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour {
	// script base para crear al pj
	private string playerName;
	private int playerLevel;

	private Character playerClass;

	//STATS
    private int hp ;
    private int strength ;
    private int intellect ;
	private int speed;
	
	private List<ItemBase> _inventory  = new List<ItemBase>();
	void  Start() {
		for (int i = 0; i < 10; i++)
		{
			ItemBase _item  = new ItemBase();
			_inventory.Add(_item);
			Debug.Log(_inventory[i].ItemName);
			Debug.Log(_inventory[i].ItemDescription);
			Debug.Log(_inventory[i].ItemValue);
			Debug.Log(_inventory[i].ItemType);
			Debug.Log(_inventory[i].ItemStats[0].Strength);
			Debug.Log(_inventory[i].ItemStats[0].Intelligence);
			Debug.Log(_inventory[i].ItemStats[0].Endurance);
			Debug.Log(_inventory[i].ItemStats[0].Hp);
			
		}
	}
	public List<ItemBase> returnPlayerInventory(){ //se encarga de dar la nueva lista de inventario
		return _inventory;
	}
	//Get Set
	public string PlayerName{
		get{return playerName;}
		set{playerName = value;}
	}

	public int PlayerLevel{
		get{return playerLevel;}
		set{playerLevel = value;}
	}

	public Character PlayerClass{
		get{return playerClass;}
		set{playerClass = value;}
	}
	public int Hp{
		get{return hp;}
		set{hp = value;}
	}
	public int Strength{
		get{return strength;}
		set{strength = value;}
	}

	public int Intellect{
		get{return intellect;}
		set{intellect = value;}
	}

	public int Speed{
		get{return speed;}
		set{speed = value;}
	}
	
}
