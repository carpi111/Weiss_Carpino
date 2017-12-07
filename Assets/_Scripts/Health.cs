using UnityEngine;

public class Health : MonoBehaviour {

	public float HP;

	public void DoDamage(float val) {
		HP -= val;
	}

	public float GetHealth() {
		return HP;
	}
}
