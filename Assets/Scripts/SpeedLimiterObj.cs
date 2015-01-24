using UnityEngine;
using System.Collections;

public class SpeedLimiterObj : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(other.name == "Body"){
			Destroy(gameObject);
		}
	}
}
