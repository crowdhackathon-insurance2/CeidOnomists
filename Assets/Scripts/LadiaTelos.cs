using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LadiaTelos : MonoBehaviour {

    public GameObject PS_Manager;
    public Text accidentsInfoText;
    public GameObject Panel_Manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == GameObject.FindGameObjectWithTag("Player").gameObject)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Mover>().canGoStraight = true;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Mover>().canTurn = true;
            PS_Manager.gameObject.SetActive(true);
            accidentsInfoText.text = "Τι κι αν τράκαρες, η ασφάλεια σου σε καλύπτει\n" + "Ο ιδιοκτήτης δεν έχει όμως ασφάλεια πυρός! Τα υπάρχοντα του καήκαν και δεν μπορεί να τα αναπληρώσει. Για περισσότερες πληροφορίες: www.eurolife.gr/el/Products/Home/MultiHomeEuelikto"; 
            Panel_Manager.SetActive(true);
           
      
            StartCoroutine(waitFunction());
        }
    }




    IEnumerator waitFunction()
    {
        yield return new WaitForSeconds(5f);
        PS_Manager.gameObject.SetActive(false);
    }
}
