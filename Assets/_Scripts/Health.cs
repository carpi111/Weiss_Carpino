// Vince Carpino
// 2260921
// carpi111@mail.chapman.edu
// CPSC 229-01 Unity Programming and Prototyping
// Final Project

// Manages the unit's health.

using UnityEngine;

public class Health : MonoBehaviour {

	public float HP;

	public void DoDamage(float val) {
		HP -= val;
	}

	public float GetHealth() {
		return HP;
	}
}
