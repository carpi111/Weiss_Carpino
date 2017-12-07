using UnityEngine;

public class Collectible : MonoBehaviour {

	public int Value;

	private GameManager GM;

	void Start () {
		GM = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
	}

	private void OnMouseDown() {
		GM.ChangeGems(Value);

		Destroy(gameObject);
	}
}
