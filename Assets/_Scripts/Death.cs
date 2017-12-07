using UnityEngine;

public class Death : MonoBehaviour {

	public bool IsPlayerUnit;

	private Health HealthObj;

	void Start () {
		HealthObj = GetComponent<Health>();
	}

	void Update () {
		if (HealthObj.GetHealth() <= 0) {
			if (IsPlayerUnit) {
				Destroy(gameObject);
			} else {
				// GIVE RESOURCES
				Destroy(gameObject);
			}
		}
	}
}
