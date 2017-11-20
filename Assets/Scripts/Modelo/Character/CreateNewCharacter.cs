using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewCharacter : MonoBehaviour {

	private PlayerBase newPlayer;
	private bool isMage;
	private bool isWarrior;
	// Use this for initialization
	void Start () {
		newPlayer = new PlayerBase();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI()
	{
		isMage = GUILayout.Toggle(isMage,"Mage Class");
		isWarrior = GUILayout.Toggle(isWarrior,"WarriorClass");
		if(GUILayout.Button("Create")){
			if(isMage){
			newPlayer.PlayerClass = new MageClass();
			} else if (isWarrior){
				newPlayer.PlayerClass = new WarriorClass();
			}
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
		
	}
}
