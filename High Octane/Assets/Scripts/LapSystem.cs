using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapSystem : MonoBehaviour {

	public List<Checkpoints> CheckPointList;

	void  Start ()
	{
		for (int i = 0; i < CheckPointList.Count; i++) {
			CheckPointList [i].checkPointNumber = i + 1;

	}

  }﻿

}