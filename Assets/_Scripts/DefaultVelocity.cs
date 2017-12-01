using UnityEngine;

public class DefaultVelocity : MonoBehaviour {

	public Vector2 velocity;
	
	private void FixedUpdate() {
		GetComponent<Rigidbody2D>().velocity = velocity;
	}
}
