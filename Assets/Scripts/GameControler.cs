using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControler : MonoBehaviour {

	private static GameControler instance;

	public string bodyName = "Body";
	public string ghostName = "Ghost";

	public Camera cam;

	public Canvas canvas;

	public Transform ghost;

	private Image ghostWins;
	private Image bodyWins;

	private bool gameOver;

	public string winner;

	// Use this for initialization
	void Start () {
		instance = new GameControler();
		instance.canvas = this.canvas;
		Image[] images = instance.canvas.GetComponentsInChildren<Image>();
		instance.gameOver = false;
		instance.canvas.enabled = false;
		instance.ghost = ghost;
		instance.cam = cam;
		foreach (Image image in images){
			image.enabled = false;
			if(image.name == "GhostWinImage")instance.ghostWins = image;
			else if(image.name == "BodyWinImage")instance.bodyWins = image;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape) && instance.gameOver)Application.LoadLevel(0);
	}

	public static void GameOver(string winnerName){
		instance._GameOver(winnerName);
	}

	public static GameControler getInstance(){
		return instance;
	}

	private void _GameOver(string winnerName){

		instance.winner = winnerName;
		AudioSource[] aus = instance.cam.GetComponents<AudioSource>();
		foreach(AudioSource au in aus){
			if(au.clip.name != "_Baby Come Back Editado") au.enabled = false;
			else au.enabled = true;
		}

		instance.canvas.enabled = true;
		Destroy(instance.ghost.gameObject);
		//Execute Body victory
		if(winnerName == "Body" && !gameOver){
			instance.bodyWins.enabled = true; 
		}
		//Execute Ghost victory
		else if(winnerName == "Ghost" && !gameOver){
			instance.ghostWins.enabled = true; 
		}

		instance.gameOver = true;

	}
}
