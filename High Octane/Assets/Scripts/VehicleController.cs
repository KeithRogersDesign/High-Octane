﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.position = transform.position + new Vector3 (0, 0, 4f);
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.position = transform.position + new Vector3 (0, 0, -0.5f);

		}

		if (Input.GetKey (KeyCode.A)) {
			transform.position = transform.position + new Vector3 (-0.5f, 0, 0);

		}

		if (Input.GetKey (KeyCode.D)) {
			transform.position = transform.position + new Vector3 (0.5f, 0, 0);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position = transform.position + new Vector3 (0, 0, 4f);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position = transform.position + new Vector3 (0, 0, -0.5f);

		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position = transform.position + new Vector3 (-0.5f, 0, 0);

		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position = transform.position + new Vector3 (0.5f, 0, 0);
		}

	}

}
