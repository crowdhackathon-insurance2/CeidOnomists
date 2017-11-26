using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(SpriteRenderer))]

public class TrafficLightController : MonoBehaviour {
    public enum States { RED, ORANGE, GREEN }

    public Sprite red;
    public Sprite green;
    public Sprite orange;

    public States state;

    void Update() {
        switch (state) {
            case States.GREEN:
                GetComponent<SpriteRenderer>().sprite = green;
                GetComponent<BoxCollider2D>().enabled = false;
                StartCoroutine(ChangeColorFanari());
                break;

            case States.ORANGE:
                GetComponent<SpriteRenderer>().sprite = orange;
                GetComponent<SendMessageOnCollision>().messageToSend = "onPassWithOrange";
                GetComponent<BoxCollider2D>().enabled = true;
                StartCoroutine(ChangeColorFanari());
               
                break;

            case States.RED:
                GetComponent<SpriteRenderer>().sprite = red;
                GetComponent<SendMessageOnCollision>().messageToSend = "onPassWithRed";
                GetComponent<BoxCollider2D>().enabled = true;
                StartCoroutine(ChangeColorFanari());
               
                break;
        }
    }

    IEnumerator ChangeColorFanari()
    {
        
        if (state == States.GREEN)
        {
            yield return new WaitForSeconds(3f);

            state = States.ORANGE;
           
        }
        else if (state == States.ORANGE)
        {
            yield return new WaitForSeconds(3f);

            state = States.RED;
        }
        else
        {
            yield return new WaitForSeconds(3f);

            state = States.GREEN;
        }
    }

}
