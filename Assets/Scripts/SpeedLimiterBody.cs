using UnityEngine;
using System.Collections;

public class SpeedLimiterBody : MonoBehaviour {
	PlayerMovementController bodyMoveController;
	// Use this for initialization
	bool isSlow;
	float slowTime;
	void Start () {
		bodyMoveController = GetComponent<PlayerMovementController>();
		isSlow = false;
		slowTime = 0.0f;
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
