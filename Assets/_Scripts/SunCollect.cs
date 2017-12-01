using UnityEngine;

public class SunCollect : MonoBehaviour {

	public static int score = 100;

	private void OnMouseDown() {
		score += 20;
		
		Destroy(gameObject);
	}
}
