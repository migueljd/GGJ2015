using UnityEngine;
using System.Collections;

public class ClickableObject : MonoBehaviour {

	public float objectSpeed = 15f;

	public Camera cam;

	public GameObject player;	

	public float playerSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		RaycastHit vHit = new RaycastHit();
		Ray vRay = cam.ScreenPointToRay(Input.mousePosition);

		if(Physics.Raycast(vRay, out vHit, 1000)){
			if(vHit.collider.gameObject.Equals(this.gameObject)){
				shootBook ();
			}
		}
	}

	private void shootBook(){
		Vector3 playerPos = player.transform.position;

	}
}
