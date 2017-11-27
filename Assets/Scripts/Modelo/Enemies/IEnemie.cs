using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemy
{
	int ID { get; set; } // id enemigo
    int Experience { get; set; }// experiencia que recibiar
    void Die(); // funcion de morir
    void TakeDamage(int amount); // el daño que recibira
    void PerformAttack(); // hace un ataque
}
