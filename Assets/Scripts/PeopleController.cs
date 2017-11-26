using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleController : MonoBehaviour {

	public GameObject startPoint;
	public GameObject stopPoint;

	//public speed;

	void Start(){
		gameObject.transform.position = startPoint.transform.position;
	}

	void Update(){
		
	}
}
