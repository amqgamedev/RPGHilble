using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character  {


	private string className;
	private string classDescription;

	//STATS
    private int hp ;
    private int strength ;
    private int intellect ;
	private int speed;
	private int xp;
	
	//Get Set
	public string ClassName{
		get{return className;}
		set{className = value;}
	}

	public string ClassDescription{
		get{return classDescription;}
		set{classDescription = value;}
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
	public int Xp{
		get{return xp;}
		set{speed = value;}
	}

}
