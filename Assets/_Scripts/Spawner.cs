using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public int NumSpawned;
	public GameObject[] AllEnemies;
	public float Cooldown;
	public int DelayStartModifier;

	private float CooldownCounter;

	public int ValidXMin;
	public int ValidXMax;
	public int ValidYMin;
	public int ValidYMax;
	public int ValidZVal;

	public int MinSpawnRate;
	public int MaxSpawnRate;

	public int SecondsBetweenSpawns;

	public GameObject ItemToSpawn;

	void Start () {
//		InvokeRepeating("StartSpawning", 0f, SecondsBetweenSpawns);
		CooldownCounter = Cooldown * DelayStartModifier;
	}

	void Update () {
		if (CooldownCounter > 0) {
			CooldownCounter -= Time.deltaTime;
		} else {
			CooldownCounter = Random.Range(MinSpawnRate, MaxSpawnRate);
			Vector3 pos = new Vector3(Random.Range(ValidXMin, ValidXMax), Random.Range(ValidYMin, ValidYMax), ValidZVal);
			int index = Random.Range(0, AllEnemies.Length);
			Instantiate(AllEnemies[index], pos, AllEnemies[index].transform.rotation);
			NumSpawned++;
		}
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
