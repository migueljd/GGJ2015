using UnityEngine;
using System.Collections;

public class BodyLightController : MonoBehaviour {

	float maxTimeLightOn;
	float timeLightOn;
	float lastLightOnOff;

	private PlayerMovementController pmc;
	// Use this for initialization
	void Start () {
		timeLightOn = 0f;
		maxTimeLightOn = 5f;
		lastLightOnOff = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		timeLightOn += Time.deltaTime;
		if(timeLightOn >= maxTimeLightOn){
//			this.collider.enabled = false;
//			if(this.pmc != null)this.pmc.canMove = true;
			Destroy (gameObject);
		}
		if(timeLightOn >= maxTimeLightOn - 2){
			if(lastLightOnOff == 0f || timeLightOn - lastLightOnOff > 0.2f){
				gameObject.light.enabled = !gameObject.light.enabled;
				lastLightOnOff = timeLightOn;
			}
		}
	}

	void OnTriggerEnter(Collider other){
//		if(other.name == "Ghost"){
//			PlayerMovementController pmc = other.gameObject.GetComponent<PlayerMovementController>();
////			int layerMask = 1 <<8;
////			layerMask = ~layerMask;
////			RaycastHit vHit = new RaycastHit();
////			Ray vRay;
////			vRay = new Ray(transform.position, other.transform.position);
////			if(Physics.Raycast(vRay, out vHit, 1000, layerMask)){
////				Debug.Log("Found the Ghost raycast");
////				if(vHit.collider.name == "Ghost"){
////					other.transform.Translate((other.transform.position - this.transform.position).normalized );
////				}
////			}
//
//		}
	}
}
