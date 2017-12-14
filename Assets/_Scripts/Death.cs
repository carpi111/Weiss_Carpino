using UnityEngine;

public class Death : MonoBehaviour {

	public bool IsPlayerUnit;
	public int Value;

	private Health HealthObj;
	private GameManager GM;

	void Start () {
		HealthObj = GetComponent<Health>();
		GM = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
	}

	void Update () {
		if (HealthObj.GetHealth() <= 0) {
			if (IsPlayerUnit) {
				Destroy(gameObject);
			} else {
				GM.ChangeGems(Value);
				Destroy(gameObject);
			}
		}
	}
}
