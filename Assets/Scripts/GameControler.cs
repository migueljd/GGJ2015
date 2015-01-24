using UnityEngine;
using System.Collections;

public class GameControler : MonoBehaviour {

	private static GameControler instance;

	public string bodyName = "Body";
	public string ghostName = "Ghost";

	// Use this for initialization
	void Start () {
		instance = new GameControler();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void GameOver(string winnerName){
		instance._GameOver(winnerName);
	}

	private void _GameOver(string winnerName){

		Debug.Log(winnerName + " wins"));
		//Execute Body victory
		if(winnerName == "Body"){
		
		}
		//Execute Ghost victory
		else if(winnerName == "Ghost"){
			
		}
	}
}
