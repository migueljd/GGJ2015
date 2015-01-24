using UnityEngine;
using System.Collections;

public class GhostMovementController : MonoBehaviour {
	public float moveSpeed = 2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		doMovement ();
	}
	
	private void doMovement(){
		float x = 0.0f;
		float y = 0.0f;
		float z = 0.0f;
		if(Input.GetKey(KeyCode.LeftArrow))
			x = -this.moveSpeed;
		if (Input.GetKey (KeyCode.RightArrow))
			x = this.moveSpeed;
		if(Input.GetKey (KeyCode.UpArrow))
			z = this.moveSpeed;
		if (Input.GetKey (KeyCode.DownArrow))
			z = -this.moveSpeed;
		this.transform.Translate(new Vector3(x,y,z) *Time.deltaTime);
	}
}
