using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public int ValidXMin;
	public int ValidXMax;
	public int ValidYMin;
	public int ValidYMax;

	public int SecondsBetweenSpawns;

	public GameObject GemToSpawn;

	void Start () {
		InvokeRepeating("StartSpawning", 0f, SecondsBetweenSpawns);
	}

	void Update () {
	}

	private void StartSpawning() {
		Spawn(GemToSpawn);
	}

	private void Spawn(GameObject obj) {
		Instantiate(
			obj,
			new Vector2(Random.Range(ValidXMin, ValidXMax), Random.Range(ValidYMin, ValidYMax)),
			Quaternion.identity
		);
	}

	IEnumerator StartSpawning(float val) {
		yield return new WaitForSeconds(val);

		Spawn(GemToSpawn);
	}
}
