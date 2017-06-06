using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour {

	public int currentCheckpoint = 0;
	public int currentLap = 0;

	public float curHP=100;
	public float maxHP=100;
	public float maxBAR=100;
	public float HealthBarLength;

	public KeyCode forwardsKey = KeyCode.W;
	public KeyCode backwardsKey = KeyCode.S;
	public KeyCode turnLeftKey = KeyCode.A;
	public KeyCode turnRightKey = KeyCode.D;


	// Update is called once per frame
	void Update () {
		    

		if (Input.GetKey (forwardsKey)) {
			gameObject.GetComponent<Rigidbody> ().AddForce
			(transform.forward * 20);
		}

		if (Input.GetKey (backwardsKey)) {
			gameObject.GetComponent<Rigidbody> ().AddForce
			(transform.forward * -80);
		}


		if (Input.GetKey (turnRightKey)) {
			gameObject.GetComponent<Rigidbody> ().AddForce
			(transform.right * 15);
		}


		if (Input.GetKey (turnLeftKey)) {
			gameObject.GetComponent<Rigidbody> ().AddForce
			(transform.right * -15);
		}

	}
	//Lets you know if you've hit checkpoints out of order
	public void HitCheckpoint(int checkpointNumber){
		if (checkpointNumber == currentCheckpoint + 1){
			currentCheckpoint = checkpointNumber;
		} else {
			Debug.Log ("Wrong checkpoint for" + transform.name);
		}

	}

	//Lets you know if you've hit checkpoints out of order
	public void HitLap(int lapNumber){
		if (lapNumber == currentLap + 1){
			currentLap = lapNumber;
		} else {
			Debug.Log ("Wrong lap" + transform.name);
		}

	}

	void OnGUI()

	{
		//This creates the health bar at the coordinates 10,10
		GUI.Box(new Rect(10,10,HealthBarLength,25), "");
		// This determines lentgh of the health bar
		HealthBarLength=curHP*maxBAR/maxHP;
	}

	void ChangeHp(float Change)
	{
		curHP+=Change;
		if (curHP > 100) 
		{
			curHP = 100;
		}	
		if (curHP <= 0) 
		{
			// Die
			Debug.Log("Your machine has been trashed!");
		}	
	}

	void OnTriggerEnter(Collider other)
	{
		switch (other.gameObject.tag) 
		{ 
		case "Player":
			ChangeHp(-25);
			break;
		}
		Destroy (other.gameObject);

		{

	}


  }

}


