using UnityEngine;

public class SunSpawn : MonoBehaviour {

	public GameObject prefab;

	void Start () {
		InvokeRepeating("Spawn", 10, 10);
	}

	void Spawn() {
		// Instantiate prefab at current position with default rotation
		Instantiate(prefab, transform.position, Quaternion.identity);
	}
}
