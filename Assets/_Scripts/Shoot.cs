// Vince Carpino
// 2260921
// carpi111@mail.chapman.edu
// CPSC 229-01 Unity Programming and Prototyping
// Final Project

// Basic shoot ability for units.

using UnityEngine;

public class Shoot : MonoBehaviour {

	public float Cooldown;
	public GameObject Bullet;
	public float RaycastDist;

	protected float CooldownCounter;

	void Start () {
		CooldownCounter = Cooldown;
	}

	void Update () {
		if (CooldownCounter > 0) {
			CooldownCounter -= Time.deltaTime;
		} else {
			RaycastHit hit;
			if (Physics.Raycast(transform.position, Vector3.right, out hit, RaycastDist - transform.position.x)) {
				if (hit.transform.CompareTag("Enemy")) {
					CooldownCounter = Cooldown;
                    Instantiate(Bullet, transform.position + Bullet.transform.position, Bullet.transform.rotation);
				}
			}
		}
	}
}
