using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private bool GoToNextLevel = false;
	private bool RestartLevel = false;

	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.R))
		{
			Restart();
		}

		if (GoToNextLevel == true)
		{
			if (SceneManager.GetActiveScene ().buildIndex - 1 == SceneManager.sceneCountInBuildSettings)
				SceneManager.LoadScene (0);
			else
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}

		if (RestartLevel == true)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}

	public void Restart()
	{
		StartCoroutine (RestartWaitTimer());
	}


	public void NextLevel()
	{
		StartCoroutine (NextLevelWaitTimer());
	}


	IEnumerator NextLevelWaitTimer()
	{
		yield return new WaitForSeconds (1.5f);
		GoToNextLevel = true;
	}

	IEnumerator RestartWaitTimer()
	{
		yield return new WaitForSeconds (0);
		RestartLevel = true;
	}

}