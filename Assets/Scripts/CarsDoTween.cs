using UnityEngine;
using System.Collections;
using DG.Tweening;

public class CarsDoTween : MonoBehaviour
{
    public Transform target;

    public Transform EndPoint;

    public float timeForMove = 3f;
    void Start()
    {

        Sequence mySequence = DOTween.Sequence();
        // Add a 1 second move tween only on the Y axis
        mySequence.Append(target.DOMove(EndPoint.position, timeForMove));
        // Add a 1 second rotation tween, using Join so it will start when the previous one starts
        //mySequence.Join(target.DORotate(new Vector3(0, 135, 0), 1));
        // Add a 1 second scale Y tween, using Append so it will start after the previously added tweens end
        
        // Add an X axis relative move tween that will start from the beginning of the Sequence
        // and last for the whole Sequence duration
        

       
        // Oh, and let's also make the whole Sequence loop backward and forward 4 times
        mySequence.SetLoops(-1, LoopType.Restart);
    }
}