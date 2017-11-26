using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public float movementSpeed = 5f;
    public float smoothing = 60f;
    public Vector3 smoothingVector = new Vector3(0f, 1f, 0f);

    public bool canTurn = true;
    public bool canGoStraight = true;
    
    // Use this for initialization

   
        
	// Update is called once per frame
	void LateUpdate () {

        if (canGoStraight) transform.Translate(new Vector3(0f, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed, 0f));
        else transform.Translate(new Vector3(0f, Time.deltaTime * movementSpeed, 0f));
        if (canTurn) transform.RotateAround(transform.position- smoothingVector,new Vector3(0f, 0f,- Input.GetAxis("Horizontal") ), smoothing * Time.deltaTime);
	}
}
