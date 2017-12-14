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
