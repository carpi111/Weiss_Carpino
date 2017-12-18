// Vince Carpino
// 2260921
// carpi111@mail.chapman.edu
// CPSC 229-01 Unity Programming and Prototyping
// Final Project

// Manages which unit is selected and where to place it.

using UnityEngine;

public class SetUnit : MonoBehaviour {

	public int Selected;
	public GameObject[] AllUnits;
	public int[] Prices;
	public GameObject Tile;

	private GameManager GM;

	void Start () {
		GM = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
	}

	void Update () {
		Selected = GM.GetSelectedUnit();

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 20)) {
			if (hit.transform.CompareTag("Tile")) {
				Tile = hit.transform.gameObject;
			} else {
				Tile = null;
			}
		}

		if (Input.GetMouseButtonDown(0) && Tile != null) {
			TileTaken TakenObj = Tile.GetComponent<TileTaken>();
			if (!TakenObj.IsTaken && GM.GetGems() >= Prices[Selected]) {
				GM.ChangeGems(-Prices[Selected]);
				Vector3 pos = new Vector3(Tile.transform.position.x + AllUnits[Selected].transform.position.x, Tile.transform.position.y + AllUnits[Selected].transform.position.y, -1f);
				TakenObj.CurrentUnit = Instantiate(AllUnits[Selected], pos, Quaternion.identity);
				TakenObj.IsTaken = true;
			}
		}
	}
}
