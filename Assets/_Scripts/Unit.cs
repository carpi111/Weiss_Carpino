using System.Collections;
using UnityEngine;

public class Unit : MonoBehaviour {

	public float Health;
	public float AttackPower;
	public string ElementType;

	private GameManager GM;

	void Start () {
		GM = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
	}

	IEnumerator WaitForTime(float val) {
		yield return new WaitForSeconds(val);
	}

	private void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Projectile") && gameObject.CompareTag("Enemy")) {     // PROJECTILE HITS ENEMY
			Health -= GM.GetPlayerProjectileDamage();

			if (Health <= 0) {
				Destroy(gameObject);
			}
		} else if (other.CompareTag("Enemy") && gameObject.CompareTag("Player")) {  // ENEMY REACHES PLAYER UNIT
			if (Health > 0) {
				Health -= GM.GetEnemyDamage();
				StartCoroutine(WaitForTime(1));
			} else
				Destroy(gameObject);
			}
		}
	}
}
