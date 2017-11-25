using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goals : MonoBehaviour {
	public string Description {get;set;} // descripcion de la meta
	public bool Completed{get;set;} // verifica si se ha completado
	public int CurrentAmount{get;set;} // la cantidad que se tiene actualmente ( pj: slimes)
	public int RequiredAmount{get;set;} // la cantidad requerida para cumplir la mison
	// Use this for initialization
	public virtual void Init(){
		
	}
	// Update is called once per frame
	void Update () {
		
	}

	public void Evaluate(){
		if(CurrentAmount >= RequiredAmount){ //si la cantidad actual es igual a la cantidad requerida lo completa
			Complete();
		}
	}

	public void Complete(){
		Completed = true;
	}
}
