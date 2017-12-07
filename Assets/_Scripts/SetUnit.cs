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
				Vector3 pos = new Vector3(Tile.transform.position.x, Tile.transform.position.y, -1f);
				TakenObj.CurrentUnit = Instantiate(AllUnits[Selected], pos, Quaternion.identity);
				TakenObj.IsTaken = true;
			}
		}
	}
}
