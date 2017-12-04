using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase{
       
        private string itemName; //nombre del item
        private string itemDescription; // descripcion del item
        private int itemValue;//valor del item
        private List<StatItemBase> itemStats;
        public ItemBase()
        {
                ItemName = "Item" + Random.Range(0,10);
                ItemDescription = ItemName + "is a Cool Stuff";
                ItemValue = Random.Range(10,100);
                ItemType = ItemTypes.EQUIPMENT;
                ItemStats = new List<StatItemBase>();
        }
        public enum ItemTypes{ // enum de tipo de items
                EQUIPMENT,
                WEAPON,
                POTION
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
        public int ItemValue{
                get{return itemValue;}
                set{itemValue = value;}
        }
        public ItemTypes ItemType{
                get{return itemType;}
                set{itemType = value;}
        }
        public List<StatItemBase> ItemStats{
                get{return itemStats;}
                set{itemStats = value;}
        }
}
