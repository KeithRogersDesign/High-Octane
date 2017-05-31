using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {
       
	public int health = 100;

	public void TakeDmage(int damageToTake) {
		health = HealthBar - damageToTake;
	}

	// Use this for Initialization 
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			Destroy (this.gameObject);
		}
	}
}