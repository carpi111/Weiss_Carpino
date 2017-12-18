// Vince Carpino
// 2260921
// carpi111@mail.chapman.edu
// CPSC 229-01 Unity Programming and Prototyping
// Final Project

// Manages UI elements so that other scripts may access them.

using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public GameObject GemsLabel;

	private GameManager GM;

	void Start () {
		GM = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
	}

	void Update () {
		SetGemsLabel();
	}

	private void SetGemsLabel() {
		GemsLabel.GetComponent<Text>().text = "Gems | " + GM.GetGems();
	}
}
