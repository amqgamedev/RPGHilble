using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase {

	private string playerName;
	private int playerLevel;

	private Character playerClass;

	//STATS
    private int hp ;
    private int strength ;
    private int intellect ;
	private int speed;
	
	
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
