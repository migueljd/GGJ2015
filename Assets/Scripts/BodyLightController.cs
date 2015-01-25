using UnityEngine;
using System.Collections;

public class BodyLightController : MonoBehaviour {

	float maxTimeLightOn;
	float timeLightOn;
	float lastLightOnOff;
	// Use this for initialization
	void Start () {
		timeLightOn = 0f;
		maxTimeLightOn = 3f;
		lastLightOnOff = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		timeLightOn += Time.deltaTime;
		if(timeLightOn >= maxTimeLightOn)
			Destroy (gameObject);
		if(timeLightOn >= maxTimeLightOn - 1){
			if(lastLightOnOff == 0f || timeLightOn - lastLightOnOff > 0.2f){
				gameObject.light.enabled = !gameObject.light.enabled;
				lastLightOnOff = timeLightOn;
			}
		}
	}
}
