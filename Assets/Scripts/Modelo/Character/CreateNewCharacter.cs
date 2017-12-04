using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateNewCharacter : MonoBehaviour{
	// script para crear personaje, da las caracteristicas y la clase al pj
	private PlayerBase newPlayer;
	
	//booleanos para determinar si es guerrero o mago
	private bool isMage;
	private bool isWarrior;

	private string playerName = "Enter Name	";
	void Start () {
		newPlayer = new PlayerBase(); // creamos un nuevo player llamando al script player base
	}
	

		
	

	public void Mage(){
		
		newPlayer.PlayerClass = new MageClass();

		newPlayer.PlayerLevel = 1;
		newPlayer.Hp = newPlayer.PlayerClass.Hp;
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
		newPlayer.Speed = newPlayer.PlayerClass.Speed;
		Debug.Log("Player Class =" + newPlayer.PlayerClass.ClassName);
		Debug.Log("Player level =" + newPlayer.PlayerLevel);
		Debug.Log("Player HP =" + newPlayer.Hp);
		Debug.Log("Player Strength =" + newPlayer.Strength);
		Debug.Log("Player Intellect =" + newPlayer.Intellect);
		Debug.Log("Player Speed =" + newPlayer.Speed);

	}

	public void Warrior(){

		newPlayer.PlayerClass = new WarriorClass();
		newPlayer.PlayerLevel = 1;
		newPlayer.Hp = newPlayer.PlayerClass.Hp;
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
		newPlayer.Speed = newPlayer.PlayerClass.Speed;	
		Debug.Log("Player Class =" + newPlayer.PlayerClass.ClassName);
		Debug.Log("Player level =" + newPlayer.PlayerLevel);
		Debug.Log("Player HP =" + newPlayer.Hp);
		Debug.Log("Player Strength =" + newPlayer.Strength);
		Debug.Log("Player Intellect =" + newPlayer.Intellect);
		Debug.Log("Player Speed =" + newPlayer.Speed);
	}

	public void NameOfThePlayer(string playername){

	Debug.Log("Player Name =" + playername);
	
	}
	



}