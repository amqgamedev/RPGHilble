using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillGoals : Goals {
    public int EnemyID { get; set; } // recibe el id

    public KillGoals(int enemyID, string description, bool completed, int currentAmount, int requiredAmount) // constructor recibe las variables del script Goals
    {
        this.EnemyID = enemyID;
        this.Description = description;
        this.Completed = completed;
        this.CurrentAmount = currentAmount;
        this.RequiredAmount = requiredAmount;
    }

	public override void Init(){ 
		base.Init(); //inicializa el goals
		CombatEvents.OnEnemyDeath += EnemyDied;//si verifica que hay un enemigo muerto entonces 
		
	}

	void EnemyDied(IEnemy enemy){ // recibe de IEnemy el id del enemigo
		if (enemy.ID == this.EnemyID)
        {
            this.CurrentAmount++; //entonces aumenta la cantidad actual
            Evaluate(); // llama a la funcion evualate para comprobar y luego completar
        }
	}

}
