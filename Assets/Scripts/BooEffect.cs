using UnityEngine;
using System.Collections;

public class BooEffect : MonoBehaviour {

	void OnTriggerStay(Collider col){
       if(col.name == "Ghost"){
            AudioSource aus = col.gameObject.GetComponent<AudioSource>();
            if(!aus.isPlaying) aus.Play();
        }
    }
}
