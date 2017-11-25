using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillGoals : Goals {
    public KillGoals(string description, bool completed, int currentAmount, int requiredAmount)
    {
		this.Description = description;
		this.Completed = completed;
		this.CurrentAmount = currentAmount;
		this.RequiredAmount = requiredAmount;
    }

	public override void Init(){
		base.Init();
	}

	void EnemyDied(){
		///
		/// en construccion.
		///
	}

}
