using UnityEngine;
using System.Collections;

public class ClickableObject : MonoBehaviour {

	public float objectSpeed = 15f;

	public Camera cam;

	public Transform bookOfEvil;

	private float nextTimeToShoot = 0f;

	public float shootInterval = 5;

	// Use this for initialization


	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0) && Time.time >= this.nextTimeToShoot){
			RaycastHit vHit = new RaycastHit();
			Ray vRay = cam.ScreenPointToRay(Input.mousePosition);
            
            if(Physics.Raycast(vRay, out vHit, 1000)){
				if(vHit.collider.gameObject.Equals(this.gameObject)){
					this.nextTimeToShoot = Time.time + shootInterval;
                    shootBook ();
                }
			}
		}
	}


	private void shootBook(){
		Instantiate(bookOfEvil, this.transform.position + (this.transform.forward)*0.5f, transform.rotation);
//		tr.forward = this.transform.forward;
	}
}
