// Vince Carpino
// 2260921
// carpi111@mail.chapman.edu
// CPSC 229-01 Unity Programming and Prototyping
// Final Project

// Inherits from base Projectile class, slows down enemies.

using UnityEngine;

public class IceProjectile : Projectile {

	public float SpeedModifier;

	private void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Enemy")) {
			other.GetComponent<Health>().DoDamage(Damage);
			other.GetComponent<ConstantMovement>().ImpactSpeed(SpeedModifier);
			Destroy(gameObject);
		}
	}
}
