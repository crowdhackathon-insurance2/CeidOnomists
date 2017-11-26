using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Sequences : MonoBehaviour
{
	public Transform target;
    public Transform StartPoint;
    public Transform EndPoint;

    public float z=90;

	void Start()
	{
		
		Sequence mySequence = DOTween.Sequence();
		// Add a 1 second move tween only on the Y axis
		mySequence.Append(target.DOMove(EndPoint.position, 3));
		// Add a 1 second rotation tween, using Join so it will start when the previous one starts
		//mySequence.Join(target.DORotate(new Vector3(0, 135, 0), 1));
		// Add a 1 second scale Y tween, using Append so it will start after the previously added tweens end
		mySequence.Append(target.DORotate(new Vector3(0f,180, z),1,RotateMode.Fast));
		// Add an X axis relative move tween that will start from the beginning of the Sequence
		// and last for the whole Sequence duration
		mySequence.Append(target.DOMove(StartPoint.position, 3));

        mySequence.Append(target.DORotate(new Vector3(0f, -180, z), 1, RotateMode.Fast));
        // Oh, and let's also make the whole Sequence loop backward and forward 4 times
        mySequence.SetLoops(-1, LoopType.Restart);
	}
}