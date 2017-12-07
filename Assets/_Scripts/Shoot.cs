using UnityEngine;

public class Shoot : MonoBehaviour {

	public float Cooldown;
	public GameObject Bullet;

	private float CooldownCounter;

	void Start () {
		CooldownCounter = Cooldown;
	}

	void Update () {
		if (CooldownCounter > 0) {
			CooldownCounter -= Time.deltaTime;
		} else {
			RaycastHit hit;
			if (Physics.Raycast(transform.position, Vector3.right, out hit, 20)) {
				if (hit.transform.CompareTag("Enemy")) {
					CooldownCounter = Cooldown;
					Instantiate(Bullet, transform.position, Quaternion.identity);
				}
			}
		}
	}
}
