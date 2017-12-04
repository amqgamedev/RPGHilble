using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillAllEnemies : Quest {

    // accede a las variables de quest, setea su informacion 
	void Start()
    {
        QuestName = "Destroy All Enemies";  
        Description = "Kill a bunch of stuff."; 
        ExperienceReward = 100;
        Goals.Add(new KillGoals(0, "Kill 5 Slimes", false, 0, 5));
        Goals.ForEach(g => g.Init());
    }
}
