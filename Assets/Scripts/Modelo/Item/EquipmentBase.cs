using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentBase : StatItemBase { // hereda los stats de los items

	public enum EquipmentTypes{
            HEAD,
            CHEST,
            LEGS,                    
            FEET,
         }
 
        private EquipmentTypes equipmentType;
        private int spellEffectID;
 
        public EquipmentTypes EquipmentType{
                get{return equipmentType;}
                set{equipmentType = value;}
 
        }
        public int SpellEffectID{
                get{return spellEffectID;}
                set{spellEffectID = value;}
               
        }
}
