using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionBase : StatItemBase { // hereda los stats de los items

	 public enum PotionTypes{ // enum tipo de pociones
                HEALTH,
                STRENGTH,
                INTELLECT,
                ENDURANCE,
                SPEED
 
        }
 
    private PotionTypes potionType;
    private int spellEffectID;// ID del efecto
 
		//get set
    public PotionTypes PotionType{
        get{return potionType;}
        set{potionType = value;}
    }
 
    public int SpellEffectID{
        get{return spellEffectID;}
        set{spellEffectID = value;}
    }
}
