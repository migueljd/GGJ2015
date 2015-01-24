using UnityEngine;
using System.Collections;

public class MovableObject : MonoBehaviour {

	public float objectSpeed = 0.5f;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(new Vector3(0, 0,this.objectSpeed)*Time.deltaTime);
	}
}
