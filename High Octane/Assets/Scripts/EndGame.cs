using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

	void OnTriggerEnter (Collider ChangeScene)
	{   
		// Changes the scene when player hits trigger
		if (ChangeScene.gameObject.CompareTag ("Player")) {
			SceneManager.LoadScene (2);

		} else if (ChangeScene.gameObject.CompareTag ("Player2")) {
			SceneManager.LoadScene (2);
		}
	}
}