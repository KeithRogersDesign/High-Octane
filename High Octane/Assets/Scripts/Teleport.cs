using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

	public GameObject teleportNode;

	//When something enters the trigger
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Vector3 nodeLocation = teleportNode.transform.position;
			Quaternion nodeRotation = teleportNode.transform.rotation;
			other.transform.position = nodeLocation;
			other.transform.rotation = nodeRotation;
		}
		else if (other.tag == "Player2") {
			Vector3 nodeLocation = teleportNode.transform.position;
			Quaternion nodeRotation = teleportNode.transform.rotation;
			other.transform.position = nodeLocation;
			other.transform.rotation = nodeRotation;
		}
	}
	// Draws a visual line to denote where the player will teleport	
	void OnDrawGizmos() {
		Gizmos.color = Color.blue;
		Gizmos.DrawLine (transform.position, teleportNode.transform.position);
	}
}