// Vince Carpino
// 2260921
// carpi111@mail.chapman.edu
// CPSC 229-01 Unity Programming and Prototyping
// Final Project

// Holds some common GameObjects that other scripts will need.

using UnityEngine;

public class GameManager : MonoBehaviour {

	public int PlayerProjectileDamage;
	public int EnemyProjectileDamage;
	public int EnemyDamage;
	public int Gems;
	public int SelectedUnit;

	public int GetGems() {
		return Gems;
	}

	public int GetPlayerProjectileDamage() {
		return PlayerProjectileDamage;
	}

	public int GetEnemyProjectileDamage() {
		return EnemyProjectileDamage;
	}

	public int GetEnemyDamage() {
		return EnemyDamage;
	}

	public void ChangeGems(int val) {
		Gems += val;
	}

	public void SetSelectedUnit(int val) {
		SelectedUnit = val;
	}

	public int GetSelectedUnit() {
		return SelectedUnit;
	}
}
