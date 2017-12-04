using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectedItem : MonoBehaviour {

	//este script hace referencia a cuando cliqueas un item te muestra su info, se debe crear un cuadro de texto
	//de nombre SelectedItemText
	private Text SelectedItemText;
	private List<ItemBase> playerInventory;
	// Use this for initialization
	void Start () {
		SelectedItemText = GameObject.Find("SelectedItemText").GetComponent<Text>();
		PlayerBase baseplayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBase>();
		playerInventory = baseplayerScript.returnPlayerInventory(); // llama una nueva lista de inventario
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowSelectedItem(){
		if(this.gameObject.GetComponent<Toggle>().isOn){
			if(	this.gameObject.name == "Empty"){
				SelectedItemText.text  = "This Slot is Empty"; // si el el objeto es Empty no muestra que el slot es empty

			}else{
				SelectedItemText.text = playerInventory[System.Int32.Parse(this.gameObject.name)].ItemName + " " + playerInventory[System.Int32.Parse(this.gameObject.name)].ItemDescription;
			// por ejemplo playerInventory[1]
			// de otro modo nos muestra el nombre del item y su descripcion
			
			}
		}
	}
}
