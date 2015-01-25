using UnityEngine;
using System.Collections;

public class SlowBookOfEvil : MonoBehaviour {

	public float speed = 15;

	public string ghostName = "Ghost";

	// Update is called once per frame
	void Update () {
		this.transform.Translate(new Vector3(0,0,1)*speed*Time.deltaTime);
	}

	void OnTriggerEnter(Collider collision) {
		if(collision.transform.name != ghostName && collision.name != "Bookshelf" && collision.name != "Crux(Clone)" && collision.name != "BooEffect"){
			Destroy(this.gameObject);
		}
	}

}
