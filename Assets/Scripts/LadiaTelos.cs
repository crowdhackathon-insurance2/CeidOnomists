using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadiaTelos : MonoBehaviour {

    public GameObject PS_Manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == GameObject.FindGameObjectWithTag("Player").gameObject)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Mover>().canGoStraight = true;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Mover>().canTurn = true;
            PS_Manager.gameObject.SetActive(true);
            StartCoroutine(waitFunction());
        }
    }




    IEnumerator waitFunction()
    {
        yield return new WaitForSeconds(5f);
        PS_Manager.gameObject.SetActive(false);
    }
}
