using UnityEngine;

public class Shoot : MonoBehaviour {

	public float Cooldown;
	public GameObject Bullet;
	public float RaycastDist;

	protected float CooldownCounter;
//	private int ShotsFiredThisPulse;

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
