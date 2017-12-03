using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour {

	private GameObject [] characterList;
	private int index;




	// Use this for initialization
	void Start () {
		
		characterList = new GameObject[transform.childCount];

		//se ponen en el array los modelos
		for (int i = 0; i < transform.childCount; i++)
			characterList[i] = transform.GetChild(i).gameObject;
		
		//se apagan los renderer
		foreach(GameObject pj in characterList)
			pj.SetActive(false);

		if (characterList[0])
			characterList[0].SetActive(true);

	}

	public void Mage()
	{
		//apagar modelo actual
		characterList[index].SetActive(false);

		index = 1;
		
		//prender nuevo modelo
		characterList[index].SetActive(true);
	}
	
	public void Warrior()
	{
		//apagar modelo actual
		characterList[index].SetActive(false);

		index = 0;
		
		//prender nuevo modelo
		characterList[index].SetActive(true);
	}
	

	public void Confirm()
	{
		SceneManager.LoadScene("PlayerGame");
	}

}
