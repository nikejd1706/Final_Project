﻿using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {
	// Movement Speed
	public float speed = 2;

	// Flap Force
	public float force = 300;

	// Use this for initialization
	void Start () {
	// Fly towards the right
		GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
		// Flap
		if (Input.GetKeyDown (KeyCode.Space))
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * force);
	}
	void OnCollisionEnter2D(Collision2D coll) {
		// Restart
		Application.LoadLevel (Application.loadedLevel);
	}
}
