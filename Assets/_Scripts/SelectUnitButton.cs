// Vince Carpino
// 2260921
// carpi111@mail.chapman.edu
// CPSC 229-01 Unity Programming and Prototyping
// Final Project

// Manages which units are able to be played based on total gems owned.

using UnityEngine;
using UnityEngine.UI;

public class SelectUnitButton : MonoBehaviour {

	public GameManager GM;
    public int Price;

	void Start () {
		GM = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
	}

    void Update()
    {
        if (Price > GM.GetGems())
        {
            gameObject.GetComponent<Button>().interactable = false;
        } else
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
    }
}
