using System.Collections;
using UnityEngine;

public class BurstShooter : Shoot {

	private int Time;
	private bool CanShoot = true;
	private int ShotsFiredThisPulse;

	public int BurstSize;

	private void Start() {
//		Time = Cooldown;
//		CooldownCounter *= BurstSize;
	}

	void Update () {
		if (Input.GetMouseButtonDown(0) && Time == 0) {
//			CooldownCounter = Cooldown;
			Time = 30;
		}
		if (Time > 0) {
			Time--;
		}
		if (Time < 0) {
			Time = 0;
		}
		if (CanShoot && Time != 0 && Time % 7 == 0 && Time > 10) {
			RaycastHit hit;
			if (Physics.Raycast(transform.position, Vector3.right, out hit, RaycastDist - transform.position.x)) {
				if (hit.transform.CompareTag("Enemy")) {
//					Time = Cooldown;
                    Instantiate(Bullet, transform.position + Bullet.transform.position, Bullet.transform.rotation);

					if (++ShotsFiredThisPulse == BurstSize) {
						CanShoot = false;
						StartCoroutine(WaitForTime(Cooldown));
					}
				}
			}
		}
	}

	private void Shoot() {
		if (CanShoot && CooldownCounter == 0) {
			CooldownCounter = 30;
		}
		if (CooldownCounter > 0) {
			CooldownCounter--;
		}
		if (CooldownCounter < 0) {
			CooldownCounter = 0;
		}
		if (CooldownCounter != 0 && CooldownCounter % 7 == 0 && CooldownCounter > 10) {
			RaycastHit hit;
			if (Physics.Raycast(transform.position, Vector3.right, out hit, RaycastDist - transform.position.x)) {
				if (hit.transform.CompareTag("Enemy")) {
//					Time = Cooldown;
                    Instantiate(Bullet, transform.position + Bullet.transform.position, Bullet.transform.rotation);
				}
			}
		}
	}

	IEnumerator WaitForTime(float val) {
		yield return new WaitForSeconds(val);

		CanShoot = true;
		ShotsFiredThisPulse = 0;
	}
}
