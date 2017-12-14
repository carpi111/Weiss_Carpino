using UnityEngine;

public class ClearRow : MonoBehaviour {

	public int DestroyDistance;

	void Update () {
		if (transform.position.x > DestroyDistance) {
			Destroy(gameObject);
		}
	}

	private void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Enemy")) {
			Destroy(other.gameObject);
		}
	}
}
