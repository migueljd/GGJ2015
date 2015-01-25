using UnityEngine;
using System.Collections;

public class EndgameBody : MonoBehaviour {

	public int objectsNeeded = 4;
	public string winObjectTag = "WinObject";
	public Transform winObjectPrefab;
	public string winObjectSpawnerTag;

	private int objectsCollected = 0;
	
	private GameObject[] spawnersList;
	private GameObject currentSpawner1;
	private GameObject currentSpawner2;

	// Use this for initialization
	void Start () {
		spawnersList = GameObject.FindGameObjectsWithTag(this.winObjectSpawnerTag);
		SpawnNewWinObject(true);
		SpawnNewWinObject(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == winObjectTag && Vector3.Distance(other.transform.position, this.transform.position) <= 1.35f){
			bool sp = other.transform.position.Equals(currentSpawner1.transform.position);
			objectsCollected+=1;
			if(objectsCollected == objectsNeeded){
				GameControler.GameOver(this.name);
			}
			else{
				if(sp)
				SpawnNewWinObject(true);
				else SpawnNewWinObject(false);
			}
		}

	}

	void SpawnNewWinObject(bool which){
		GameObject spawner;

		if(which){
			spawner = currentSpawner1;
			do{
				spawner = spawnersList[Random.Range(0, spawnersList.Length)];
			}
			while(spawner != null && (spawner.Equals(currentSpawner1) || spawner.Equals(currentSpawner2)));
			currentSpawner1 = spawner;
			Instantiate(winObjectPrefab, currentSpawner1.transform.position, Quaternion.identity);	
		}
		else{
			spawner = currentSpawner2;
			do{
				spawner = spawnersList[Random.Range(0, spawnersList.Length)];
			}
			while(spawner != null && (spawner.Equals(currentSpawner1) || spawner.Equals(currentSpawner2)));
			currentSpawner2 = spawner;
			Instantiate(winObjectPrefab, currentSpawner2.transform.position, Quaternion.identity);	
        }
	}
}
