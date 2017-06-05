using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapSystem : MonoBehaviour {

	public List<Checkpoints> CheckPointList;
	public List<Laps> LapList;
	public int lapCount =  0;

	public Text lapText; 

	void  Start ()
	{
		UpdateText ();

		for (int i = 0; i < CheckPointList.Count; i++) {
			CheckPointList [i].checkPointNumber = i + 1;

		}

		{

			for (int i = 0; i < LapList.Count; i++) {
				LapList [i].lapNumber = i + 1;

				UpdateText ();
			}
		}
	}
		    private void UpdateText(){
		    lapText.text = lapCount.ToString ();
	}
 }