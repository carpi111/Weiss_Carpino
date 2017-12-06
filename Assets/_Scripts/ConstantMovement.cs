using UnityEngine;

public class ConstantMovement : MonoBehaviour {

	public float MoveSpeed;
	public Vector3 MoveDirection;
	
	private void FixedUpdate() {
		gameObject.transform.Translate(MoveDirection * MoveSpeed * Time.deltaTime);
	}
}
