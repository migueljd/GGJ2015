using UnityEngine;
using System.Collections;

public class TurnBodyLightOn : MonoBehaviour {

	private Transform bodyLight;
	public float lightTimeLeft = 3f;
	public Transform lightPrefab;

	public Transform lightAudioSource;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other){
		if(other.name == "Body"){
			Debug.Log ("Here!");
			bodyLight = (Transform) Instantiate(lightPrefab) ;
			bodyLight.parent = other.gameObject.transform;
			bodyLight.position = other.gameObject.transform.position + new Vector3(0,2,0);
			AudioSource audioA = lightAudioSource.GetComponent<AudioSource>();
			audioA.Play();
			Destroy (gameObject);
            
        }
	}


}