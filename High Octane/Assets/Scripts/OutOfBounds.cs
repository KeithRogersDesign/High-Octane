using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour 
{
	
	public GameObject playerExplosion;

	void OnTriggerExit(Collider other)
	{  

	Instantiate (playerExplosion, transform.position, transform.rotation);
    if (other.tag == "Player")
	{
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
	}
		
		Destroy (other.gameObject);


  }

}
