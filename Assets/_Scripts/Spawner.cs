using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public int ValidXMin;
	public int ValidXMax;
	public int ValidYMin;
	public int ValidYMax;

	public int MinSpawnRate;
	public int MaxSpawnRate;

	public int SecondsBetweenSpawns;

	public GameObject ItemToSpawn;

	void Start () {
		InvokeRepeating("StartSpawning", 0f, SecondsBetweenSpawns);
	}

	void Update () {
	}

	private void StartSpawning() {
		Spawn(ItemToSpawn);
	}

	private void Spawn(GameObject obj) {
		Instantiate(
			obj,
			new Vector3(Random.Range(ValidXMin, ValidXMax), Random.Range(ValidYMin, ValidYMax), -1),
			Quaternion.identity
		);
	}

	IEnumerator StartSpawning(float val) {
		yield return new WaitForSeconds(val);

		Spawn(ItemToSpawn);
	}
}
