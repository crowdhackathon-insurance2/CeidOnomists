using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class StatsPanelController : MonoBehaviour {
	Text textHolder;
	// Use this for initialization
	void Start () {
		textHolder = GameObject.Find ("TextHolder").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		string toShow = "";

		toShow += "Ατυχήματα: " + PlayerMove.accidents + "\n";
		toShow += "ΚΟΚΚΙΝΟ: " + PlayerMove.passWithRed + "\n";
		toShow += "ΠΟΡΤΟΚΑΛΙ: " + PlayerMove.passWithOrange + "\n";
		toShow += "STOP χωρίς έλεγχο: " + PlayerMove.passStopWithoutStoping + "\n";
		toShow += "Αντίθετο ρεύμα: " + PlayerMove.timeGotWrongRoad + "\n";

		textHolder.text = toShow;
	}
}
