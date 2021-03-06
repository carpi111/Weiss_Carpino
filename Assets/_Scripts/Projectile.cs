﻿// Vince Carpino
// 2260921
// carpi111@mail.chapman.edu
// CPSC 229-01 Unity Programming and Prototyping
// Final Project

// Basic projectile script for unit bullets.

using UnityEngine;

public class Projectile : MonoBehaviour {

	public float Damage;
	public float MoveSpeed;
	public int DestroyDistance;
	public Vector3 InitPos;
	public Vector3 MoveDirection;
	public GameObject Explosion;

	private void Start() {
		InitPos = transform.position;
	}

	protected void Update() {
		transform.Translate(MoveDirection * MoveSpeed * Time.deltaTime);

		if (Vector3.Distance(transform.position, InitPos) > DestroyDistance) {
			Destroy(gameObject);
		}
	}

	protected void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Health>().DoDamage(Damage);
            Destroy(gameObject);
        }
	}
}
