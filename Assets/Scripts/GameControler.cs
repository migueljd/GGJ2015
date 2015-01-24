using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControler : MonoBehaviour {

	private static GameControler instance;

	public string bodyName = "Body";
	public string ghostName = "Ghost";

	private Text winText;
	public Canvas canvas;

	// Use this for initialization
	void Start () {
		instance = new GameControler();
		instance.canvas = this.canvas;
		instance.winText = this.winText;
		Text[] texts = instance.canvas.GetComponentsInChildren<Text>();

		instance.canvas.enabled = false;
		foreach (Text text in texts){
			Debug.Log(text);
			if(text.name == "Win Text") instance.winText = text;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void GameOver(string winnerName){
		instance._GameOver(winnerName);
	}

	private void _GameOver(string winnerName){

		instance.canvas.enabled = true;
		Time.timeScale = 2;
		Debug.Log(winnerName + " wins");
		//Execute Body victory
		if(winnerName == "Body"){
			instance.winText.text = "Body wins!!!";
		}
		//Execute Ghost victory
		else if(winnerName == "Ghost"){
			instance.winText.text = "Ghost wins!!!";
		}


	}
}
