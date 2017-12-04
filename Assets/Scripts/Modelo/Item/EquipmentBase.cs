using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentBase : StatItemBase { // hereda los stats de los items

	public enum EquipmentTypes{ // enum tipo de equipamiento
            HEAD,
            CHEST,
            LEGS,                    
            FEET,
         }
 
        private EquipmentTypes equipmentType;
        private int spellEffectID;
        
        // GET SET
        public EquipmentTypes EquipmentType{
                get{return equipmentType;}
                set{equipmentType = value;}
 
        }
        
}
