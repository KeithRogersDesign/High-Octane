using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour 
{
	
	public GameObject playerExplosion;

	void OnTriggerEnter(Collider other)
	{  
		// Grabs the player object
		if (other.gameObject.tag == "Player")
	{
			Destroy (other.gameObject);
	}
		



  }

}
