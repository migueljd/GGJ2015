using UnityEngine;
using System.Collections;

public class EndgameObject : MonoBehaviour {



	

	void OnTriggerEnter(Collider other){
		if(other.name == "Body"){
			Destroy(gameObject);
		}
	}

}
