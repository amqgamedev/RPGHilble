using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatItemBase : ItemBase { // hereda la base de los items


	//stats de los items

	private int hp;
    private int endurance;
    private int strength;
    private int intelligence;
       
	//get set
    public int Hp{
        get {return hp;}
        set {hp = value;}
    }
    public int Endurance{
        get {return endurance;}
        set {endurance = value;}
    }
    public int Strength{
        get {return strength;}
        set {strength = value;}
        }
    public int Intelligence{
        get {return intelligence;}
        set {intelligence = value;}
    }
}
