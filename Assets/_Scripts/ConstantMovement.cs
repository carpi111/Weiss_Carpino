// Vince Carpino
// 2260921
// carpi111@mail.chapman.edu
// CPSC 229-01 Unity Programming and Prototyping
// Final Project

// When placed on an object, moves at a constant rate in set direction.

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
