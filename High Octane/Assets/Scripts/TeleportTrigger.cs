using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTrigger : MonoBehaviour {



	//When something enters the Trigger
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Debug.Log ("Happy to see you");
		}
		else if (other.tag == "Player2") {
			Debug.Log ("Happy to see you");

	}
}
	//When something exits the trigger
	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {
			Debug.Log ("Sorry to see you go");
		}
		else if (other.tag == "Player2") {
			Debug.Log ("Sorry to see you go");
	}
}
	//When something exits the Trigger
	void OnTriggerStay(Collider other){
		if (other.tag == "Player") {
			Debug.Log ("I wish you would leave");
		}
		else if (other.tag == "Player2") {
			Debug.Log ("I wish you would leave");
	    }
	}
}


