using UnityEngine;
using System.Collections;

public class RoadSpawner : MonoBehaviour {

	public GameObject Road;
	
	public GameObject RoadPrefab;
	
	private double SpawnFrequency;
	// Use this for initialization
	void Start () {
		SpawnFrequency = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(SpawnFrequency<=0){
			Spawn ();
			SpawnFrequency=1.9f;
		}
		SpawnFrequency -= Road.GetComponent<RoadMovement> ().Speed;					
	}
	
	void Spawn(){
		GameObject roadCollection = (GameObject)(Instantiate (RoadPrefab, new Vector3 (0f,0f,25.5f),Quaternion.identity));
		roadCollection.transform.parent = Road.transform;
	}
}
