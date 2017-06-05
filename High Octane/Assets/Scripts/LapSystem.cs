using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapSystem : MonoBehaviour {

	public List<Checkpoints> CheckPointList;
	public int lapNumber = 3;

	public Text lapText; 

	void  Start ()
	{

		for (int i = 0; i < CheckPointList.Count; i++) {
			CheckPointList [i].checkPointNumber = i + 1;

		}

	}
}