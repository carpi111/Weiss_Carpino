using UnityEngine;

public class Projectile : MonoBehaviour {

	public float Damage;
	public float MoveSpeed;
	public int DestroyDistance;
	public Vector3 InitPos;
	public Vector3 MoveDirection;
	public GameObject Explosion;

	private void Start() {
		InitPos = transform.position;
	}

	private void Update() {
		transform.Translate(MoveDirection * MoveSpeed * Time.deltaTime);

		if (Vector3.Distance(transform.position, InitPos) > DestroyDistance) {
			Destroy(gameObject);
		}
	}

	private void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Enemy")) {
			other.GetComponent<Health>().DoDamage(Damage);
			// CREATE EXPLOSION EFFECT
			Destroy(gameObject);
		}
	}
}
