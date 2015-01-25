using UnityEngine;
using System.Collections;

public class SpeedLimiterBody : MonoBehaviour {
	PlayerMovementController bodyMoveController;
	// Use this for initialization
	void Start () {
		bodyMoveController = GetComponent<PlayerMovementController>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){
	if(other.tag == "turnSlowObject"){
			bodyMoveController.addBodySlow();
		}
	}



}
