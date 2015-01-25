using UnityEngine;
using System.Collections;

public class EndgameGhost : MonoBehaviour {

	public string bodyName = "Body";
	

	void OnTriggerStay(Collider other){
		if(other.name == bodyName){
			Transform t = other.transform.Find("Point light(Clone)");
			if(t == null)GameControler.GameOver(this.name);
		}
		
	}
}
