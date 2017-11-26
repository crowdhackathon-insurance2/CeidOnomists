using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSingController : MonoBehaviour {

	public float minLegalDiference;

	private float startTime;

	void OnTriggerEnter2D(){
		float startTime = Time.time;
	}

	void OnTriggerExit2D(){
		float stopTime = Time.time;

		float diference = stopTime - startTime;

		if (diference <= minLegalDiference) {
			GameObject.FindGameObjectWithTag ("GlobalGameManager").BroadcastMessage ("onPassStopWithoutStoping",gameObject);
		}

	}
}
