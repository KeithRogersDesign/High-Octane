using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour {

	public float movementSpeed = 100f;
	public float rotateSpeed = 5;

	public KeyCode forwardsKey = KeyCode.W;
	public KeyCode backwardsKey = KeyCode.S;
	public KeyCode turnLeftKey = KeyCode.A;
	public KeyCode turnRightKey = KeyCode.D;

	public int health = 100;

	public void TakeDamage(int damageToTake) {
		health = health - damageToTake;
	}

	// Update is called once per frame
	void Update () {

		if (health <= 0) {
			//this exists the function and does not run anything after that.
			return;

		}	

		if (Input.GetKey (forwardsKey)) {
			transform.position += transform.forward *
				movementSpeed;			
		}

		if (Input.GetKey (backwardsKey)) {
			transform.position += transform.forward *
				-movementSpeed;	
		}

		if (Input.GetKey (turnRightKey)) {
			transform.position += transform.right *
				movementSpeed;	

		}

		if (Input.GetKey (turnLeftKey)) {
			transform.position += transform.right *
				-movementSpeed;	

		}

	}
}