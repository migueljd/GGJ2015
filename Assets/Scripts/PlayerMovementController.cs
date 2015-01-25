using UnityEngine;
using System.Collections;

public class PlayerMovementController : MonoBehaviour {
	public float bodyMoveSpeed = 2f;
	public float ghostMoveSpeed = 2f;
	public float movementLostOnSlow = 0.5f;
	float slowTime;
	bool isSlow;
	// Use this for initialization
	void Start () {
		slowTime = 0;
		isSlow = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (this.name == "Ghost")
			doMovementGhost ();
		if (this.name == "Body") {
			if (isSlow ==true) { 
				timer();
				if(slowTime <= 0.0f){
					bodyMoveSpeed = bodyMoveSpeed / movementLostOnSlow;
					isSlow = false;
					Debug.Log ("fast - " + bodyMoveSpeed);
				}
			}		
			doMovementBody (); 
		}
	}

	private void doMovementBody(){
		float x = 0.0f;
		float y = 0.0f;
		float z = 0.0f;
		if(Input.GetKey(KeyCode.A))
			x = -this.bodyMoveSpeed;
		if (Input.GetKey (KeyCode.D))
			x = this.bodyMoveSpeed;
		if(Input.GetKey (KeyCode.W))
			z = this.bodyMoveSpeed;
		if (Input.GetKey (KeyCode.S))
			z = -this.bodyMoveSpeed;



		Vector3 toLook = new Vector3(x,y,z);
		this.transform.Translate(toLook *Time.deltaTime, Space.World);
		if(toLook != Vector3.zero){
			transform.rotation = Quaternion.LookRotation(toLook);
		}
	}

	private void doMovementGhost(){
		float x = 0.0f;
		float y = 0.0f;
		float z = 0.0f;
		if(Input.GetKey(KeyCode.LeftArrow))
			x = -this.ghostMoveSpeed;
		if (Input.GetKey (KeyCode.RightArrow))
			x = this.ghostMoveSpeed;
		if(Input.GetKey (KeyCode.UpArrow))
			z = this.ghostMoveSpeed;
		if (Input.GetKey (KeyCode.DownArrow))

			z = -this.ghostMoveSpeed;
		Vector3 toLook = new Vector3(x,y,z);
		this.transform.Translate(toLook *Time.deltaTime, Space.World);
		if(toLook != Vector3.zero){
			transform.rotation = Quaternion.LookRotation(toLook);
		}
	}

	public void addBodySlow(){
		if (!isSlow) {
			bodyMoveSpeed = bodyMoveSpeed * movementLostOnSlow;
			slowTime = 3f;
			timer ();
			isSlow = true;
		} else {
			slowTime += 2f;
		}
		Debug.Log("slow - " + bodyMoveSpeed + " for " + slowTime);
	}

	private void timer(){
		slowTime -= Time.deltaTime;
	}
}
