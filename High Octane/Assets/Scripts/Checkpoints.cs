﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour {

	public int checkPointNumber;

	//What happens when you enter the checkpoints
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			other.GetComponent<VehicleController> ().HitCheckpoint (checkPointNumber);
		}
		else if (other.tag == "Player2") {
			other.GetComponent<VehicleController2> ().HitCheckpoint (checkPointNumber);
		}
	}
 }

