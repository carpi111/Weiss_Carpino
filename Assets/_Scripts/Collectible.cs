// Vince Carpino
// 2260921
// carpi111@mail.chapman.edu
// CPSC 229-01 Unity Programming and Prototyping
// Final Project

// Allows GameObject to be collected via mouse click.

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
