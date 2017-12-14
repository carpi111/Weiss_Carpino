using UnityEngine;

public class ConstantMovement : MonoBehaviour {

	public float MoveSpeed;
	public Vector3 MoveDirection;

	private float OriginalMoveSpeed;

	private void Start() {
		OriginalMoveSpeed = MoveSpeed;
	}

	public void ImpactSpeed(float val) {
		MoveSpeed = OriginalMoveSpeed * val;
	}

	private void FixedUpdate() {
		gameObject.transform.Translate(MoveDirection * MoveSpeed * Time.deltaTime);
	}
}
