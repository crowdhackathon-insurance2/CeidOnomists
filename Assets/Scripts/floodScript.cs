using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floodScript : MonoBehaviour {

    public Transform Player;
    public float speedReduce =0.75f;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Player.gameObject)
        {
            
            Player.GetComponent<Mover>().movementSpeed *= speedReduce;
            StartCoroutine(GameEnds());
        }
        
    }

    IEnumerator GameEnds()
    {
        yield return new WaitForSeconds(3);
        print("Game ENDED");
        Application.Quit();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == Player.gameObject)
        {
            Player.GetComponent<Mover>().movementSpeed /= speedReduce;
        }
    }
}
