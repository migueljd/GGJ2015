using UnityEngine;
using System.Collections;

public class EndgameGhost : MonoBehaviour {

	public string bodyName = "Body";
	

	void OnTriggerEnter(Collider other){
		if(other.name == bodyName){
			GameControler.GameOver(this.name);
		}
		
	}
}
