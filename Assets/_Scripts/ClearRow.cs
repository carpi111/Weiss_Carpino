// Vince Carpino
// 2260921
// carpi111@mail.chapman.edu
// CPSC 229-01 Unity Programming and Prototyping
// Final Project

// Placed on a unit that sweeps its row and deals damage along the way.

using UnityEngine;

public class ClearRow : MonoBehaviour {

	public int DestroyDistance;
	public bool OneEnemy;
	public int MaxEnemiesToKill;

	private int EnemiesKilled;

	void Update () {
		if (transform.position.x > DestroyDistance) {
			Destroy(gameObject);
		}
	}

	private void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Enemy")) {
			if (EnemiesKilled < MaxEnemiesToKill) {
                other.GetComponent<Health>().DoDamage(other.GetComponent<Health>().HP);
				//Destroy(other.gameObject);
				if (++EnemiesKilled == MaxEnemiesToKill) {
					Destroy(gameObject);
				}
			}
		}
	}
}
