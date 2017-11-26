using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour {

    public Transform target;
    //what camera is following
    public float smoothing = 5; //dampening effect

    Vector3 offset;
    Vector3 lastTargetPos;
    float lowY;

    private void Start()
    {
        Vector3 camPosition = new Vector3(target.position.x, target.position.y , target.position.z - 15);
        transform.position = camPosition;
    }
    private void LateUpdate()
    {


        Vector3 camPosition = new Vector3(target.position.x, target.position.y , target.position.z - 15);
        transform.position = Vector3.Lerp(transform.position, camPosition, smoothing * Time.deltaTime);

       
    }
}
