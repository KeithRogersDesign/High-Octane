using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public List<GameObject> raceTracks = new List<GameObject> ();


	public float depthOfRaceTrack = 2;

	public float playerPositionCounter = 0;
	public GameObject player;

	int raceTrackCounter = 0;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 40; i++) {
			BuildTrack ();
		}
	}

	void Update(){
		if (player.transform.position.z > playerPositionCounter) {
			playerPositionCounter += depthOfRaceTrack;

			BuildTrack ();
		}

	}

	private void BuildTrack(){

		GameObject raceTrackToPlace = null;
		int randomPiece = Random.Range (0, 3);

		if (randomPiece == 0) {
		} else if (randomPiece == 1) {

		} else if (randomPiece == 2) {

		}

		Instantiate (raceTracks[Random.Range(0, raceTracks.Count)],
			Vector3.forward * raceTrackCounter * depthOfRaceTrack,
			Quaternion.identity);
		raceTrackCounter++;

	}

}
