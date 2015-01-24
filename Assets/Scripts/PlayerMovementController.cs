using UnityEngine;
using System.Collections;

public class PlayerMovementController : MonoBehaviour {
	public float moveSpeed = 2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.name == "Ghost")
			doMovementGhost ();
		if (this.name == "Body")
			doMovementBody (); 
	}

	private void doMovementBody(){
		float x = 0.0f;
		float y = 0.0f;
		float z = 0.0f;
		if(Input.GetKey(KeyCode.A))
			x = -this.moveSpeed;
		if (Input.GetKey (KeyCode.D))
			x = this.moveSpeed;
		if(Input.GetKey (KeyCode.W))
			z = this.moveSpeed;
		if (Input.GetKey (KeyCode.S))
			z = -this.moveSpeed;
		this.transform.Translate(new Vector3(x,y,z) *Time.deltaTime);
	}

	private void doMovementGhost(){
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
