using UnityEngine;
using System.Collections;

public class EndgameBody : MonoBehaviour {

	public int objectsNeeded = 4;
	public string winObjectName = "Crux";
	private int objectsCollected = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(other.name == winObjectName){
			objectsCollected+=1;
			if(objectsCollected == objectsNeeded){
				GameControler.GameOver(this.name);
			}
		}

	}
}
