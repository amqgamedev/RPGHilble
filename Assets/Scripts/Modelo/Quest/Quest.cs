using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Quest : MonoBehaviour {

	public List<Goals> Goals { get; set; } // lista de objetivos
    public string QuestName { get; set; } //nombre del quest
    public string Description { get; set; } // su descripcion
    public bool Completed { get; set; } // si esta completado o no.
    public int ExperienceReward { get; set; } // experiencia que recibiar
    public void CheckGoals()
    {
        Completed = Goals.All(g => g.Completed); // revisa si en el script de goals se cumplen los objetivos si es asi lo pone true
		
        
    }

    
}
