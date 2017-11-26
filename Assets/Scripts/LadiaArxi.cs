using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadiaArxi : MonoBehaviour {



    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == GameObject.FindGameObjectWithTag("Player").gameObject)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Mover>().canGoStraight = false;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Mover>().canTurn = false;
        }
    }
}
