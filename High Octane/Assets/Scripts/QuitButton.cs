using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour {

	//What happens when you click on the exit button
	public void DoExitQuit ()
	{
			Application.Quit ();
		    Debug.Log ("Game has exited");
	}
}