using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour {

	public void DoExitQuit ()
	{
			Application.Quit ();
		    Debug.Log ("Game has exited");
	}
}