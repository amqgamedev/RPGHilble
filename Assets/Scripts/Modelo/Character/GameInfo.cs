using System.Collections;
using UnityEngine;

public class GameInfo : MonoBehaviour {

	// de prueba para almacenar los datos el personaje al cargar escena
	void Awake()
	{
		DontDestroyOnLoad(transform.gameObject);
	}

	public static string PlayerName{get;set;}
	public static int PlayerLevel{get;set;}
	public static PlayerBase PlayerClass{get;set;}
	public static int HP{get;set;}
	public static int Strength{get;set;}
	public static int Intellect{get;set;}
	public static int Speed{get;set;}


}
