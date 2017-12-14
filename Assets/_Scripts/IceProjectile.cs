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
