using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

	//se necesita crear un panel en el canvas, en el panel va un boton para cerrar la ventaba usando 
	// setActive = false;
	//para el prefab del item se puede crear una imagen que haga de slot, como hijo otra imagen del objeto.
	public int startposX;
	public int startposY;
	public int slotPerPage;
	public int slotLength;
	public GameObject ItemSlotPrefab;
	public ToggleGroup ItemSlotToggleGroup;

	private int posX;
	private int posY;
	private GameObject itemSlot;
	private int itemSlotCnt; // contador de slots
	private List<GameObject> InventorySlots;

	private List <ItemBase> playerInventory;
	// Use this for initialization
	void Start () {
		CreateInventorySlotsInWindow();
		AddItemFromInventory();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void CreateInventorySlotsInWindow(){
		InventorySlots = new List<GameObject>();
		posX = startposX;
		posY = startposY;
		for (int i = 0; i < itemSlotCnt; i++) // recorre la cantidad de contador de item slot y crea un slot cada vez que lo recorre
		{
			
			itemSlot = (GameObject) Instantiate(ItemSlotPrefab);
			itemSlot.name = "Empty";
			itemSlot.GetComponent<Toggle>().group = ItemSlotToggleGroup;
			InventorySlots.Add(itemSlot);
			itemSlot.transform.SetParent(this.gameObject.transform);
			itemSlot.GetComponent<RectTransform>().localPosition = new Vector3(posX,posY,0);
			posX += (int) itemSlot.GetComponent<RectTransform>().rect.width;
			itemSlotCnt++;
			if(itemSlotCnt % slotLength == 0){
				itemSlotCnt = 0;
				posY-=(int)itemSlot.GetComponent<RectTransform>().rect.width;
				posX = startposX;
			}
		}
	}

	private void AddItemFromInventory(){ // añade un item al inventario, es necesario que el player tenga el script player base
		PlayerBase  basePlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBase>();
		playerInventory = basePlayerScript.returnPlayerInventory();
		for (int i = 0; i < playerInventory.Count; i++)
		{
			if(InventorySlots[i].name == "Empty"){
				InventorySlots[i].name = i.ToString(); // nombre del item
			}
		}
	}
}
