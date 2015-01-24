using UnityEngine;
using System.Collections;

public class EndgameBody : MonoBehaviour {

	public int objectsNeeded = 4;
	public string winObjectTag = "WinObject";
	public Transform winObjectPrefab;
	public string winObjectSpawnerTag;

	private int objectsCollected = 0;
	
	private GameObject[] spawnersList;
	private GameObject currentSpawner;

	// Use this for initialization
	void Start () {
		spawnersList = GameObject.FindGameObjectsWithTag(this.winObjectSpawnerTag);
		SpawnNewWinObject();
		Debug.Log (spawnersList.Length);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == winObjectTag){
			objectsCollected+=1;
			if(objectsCollected == objectsNeeded){
				GameControler.GameOver(this.name);
			}
			else{
				SpawnNewWinObject();
			}
		}

	}

	void SpawnNewWinObject(){
		GameObject tempSpawner = currentSpawner;
		do{
			currentSpawner = spawnersList[Random.Range(0, spawnersList.Length)];
		}
		while(tempSpawner != null && tempSpawner.Equals(currentSpawner));
		Instantiate(winObjectPrefab, currentSpawner.transform.position, Quaternion.identity);	
	}
}
