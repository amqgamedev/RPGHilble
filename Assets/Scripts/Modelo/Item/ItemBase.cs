using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase{
       
        private string itemName; //nombre del item
        private string itemDescription; // descripcion del item
        private int itemID;//ID del item
        public enum ItemTypes{ // enum de tipo de items
                EQUIPMENT,
                WEAPON,
                POTION,
                CHEST
        }
        private ItemTypes itemType;
       
	   // get set de las variables
        public string ItemName{
                get{return itemName;}
                set{itemName = value;}
        }
        public string ItemDescription{
                get{return itemDescription;}
                set{itemDescription = value;}
        }
        public int ItemID{
                get{return itemID;}
                set{itemID = value;}
        }
        public ItemTypes ItemType{
                get{return itemType;}
                set{itemType = value;}
        }
}
