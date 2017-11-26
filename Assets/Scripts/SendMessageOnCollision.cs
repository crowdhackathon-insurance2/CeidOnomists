using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(BoxCollider2D))]
public class SendMessageOnCollision : MonoBehaviour {
    
	public string messageToSend;
    public Image damageScreen;
  //  Color damagedStartColour = new Color(0f, 0f, 0f, 0f);
  //  Color damagedColour = new Color(0f, 0f, 0f, 1f);
    private GameObject receiver;
   
    private GameObject[] Persons;
    private GameObject[] Cars;

    void Start(){
		receiver = GameObject.FindWithTag ("GlobalGameManager");
        Persons = GameObject.FindGameObjectsWithTag("Person");
        Cars = GameObject.FindGameObjectsWithTag("Cars");
        
    }
    
	void OnTriggerEnter2D(){
		receiver.BroadcastMessage (messageToSend, gameObject, SendMessageOptions.RequireReceiver);
        foreach (GameObject person in Persons)
        {
            if (gameObject == person)
            {
                damageScreen.gameObject.SetActive(true);
                StartCoroutine(WaitFuncion());
            }
        }

        foreach (GameObject car in Cars)
        {
            if (gameObject == car)
            {
                damageScreen.gameObject.SetActive(true);
                StartCoroutine(WaitFuncion());
            }
        }


        

    }

    IEnumerator WaitFuncion()
    {
		gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		yield return new WaitForSeconds(0.5f);
        damageScreen.gameObject.SetActive(false);
        Destroy(gameObject);
    }

   
}
