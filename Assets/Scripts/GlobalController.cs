using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalController : MonoBehaviour {

//	public List<PlayerMove> playerMoves;

	private static GlobalController instance;

	void Awake(){
		if(instance == null){
			instance = this;
			DontDestroyOnLoad(gameObject);
		} else if(instance != this){
			Destroy(this.gameObject);
			return;
		}
	}
    private void Start()
    {
//        playerMoves = new List<PlayerMove>();
    }

    //Implement all received Messages Here

    void onHitTheHome(GameObject sender){
		PlayerMove.accidents++;
	}

	void onPassWithRed (GameObject sender){
		PlayerMove.passWithRed++;
	}
    void onCarHit(GameObject sender) {
		PlayerMove.accidents++;
    }
    void onPassWithOrange(GameObject sender){
		PlayerMove.passWithOrange++;
    }

    void onPassStopWithoutStoping (GameObject sender){
		PlayerMove.passStopWithoutStoping++;
	}

    void onPedestrianHit(GameObject sender) {
		PlayerMove.accidents++;
    }

	void onHitHouse(GameObject sender){
		PlayerMove.accidents++;
	}

	void onWrongDirection(GameObject sender){
		PlayerMove.timeGotWrongRoad++;
	}
}
