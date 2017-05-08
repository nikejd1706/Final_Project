﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	// The target
	public Transform target;

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (target.position.x,
			transform.position.y, transform.position.z);
	}
}
