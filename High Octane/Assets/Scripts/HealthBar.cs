using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {
	public float curHP=100;
	public float maxHP=100;
	public float maxBAR=100;
	public float HealthBarLength;

	public int Money = 0;

	void OnGUI()
	{
		//This creates the health bar at the coordinates 10,10
		GUI.Box(new Rect(10,10,HealthBarLength,25), "");
		// This determines lentgh of the health bar
		HealthBarLength=curHP*maxBAR/maxHP;
	}

	void ChangeHP(float Change)
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
		case "Energy pad":
			ChangeHP(25);
			break;
		}
		Destroy (other.gameObject);
	}
}