using UnityEngine;
using System.Collections;

public class TurnBodyLightOn : MonoBehaviour {

	public GameObject bodyLight;
	public float lightTimeLeft = 3f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other){
		if(other.name == "Body"){
			Debug.Log ("Here!");
			bodyLight = Instantiate(Resources.Load("bodyLight", typeof(GameObject))) as GameObject;
			bodyLight.transform.parent = other.gameObject.transform;
			bodyLight.transform.position = other.gameObject.transform.position;
			Destroy (gameObject);
		}
	}
}