using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour 
{
	
	public GameObject playerExplosion;

	void OnTriggerEnter(Collider other)
	{  

	//Instantiate (playerExplosion, transform.position, transform.rotation);
		if (other.gameObject.tag == "Player")
	{
			//Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
	}
		



  }

}
