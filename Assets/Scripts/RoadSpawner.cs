using UnityEngine;
using System.Collections;

public class RoadSpawner : MonoBehaviour {

	public GameObject Road;
	
	public GameObject RoadPrefab;

	public GameObject JunctionPrefab;

	public bool hasJunction;
	public double JunctionTimer;

	private double JT;
	
	private double SpawnFrequency;
	// Use this for initialization
	void Start () {
		SpawnFrequency = 0;
		hasJunction = false;
		JT = JunctionTimer;
	}
	
	// Update is called once per frame
	void Update () {
		if(SpawnFrequency<=0 && !hasJunction){
			Spawn ();
			SpawnFrequency=1.9f;
		}
		SpawnFrequency -= Road.GetComponent<RoadMovement> ().Speed;	
		JT--;
		if (JT <= 0) {
			SpawnJunction();
			JT = JunctionTimer;
		}
	}
	
	void Spawn(){
		GameObject roadCollection = (GameObject)(Instantiate (RoadPrefab, new Vector3 (0f,0f,25.5f),Quaternion.identity));
		roadCollection.transform.parent = Road.transform;
	}

	void SpawnJunction(){
		GameObject roadCollection = (GameObject)(Instantiate (JunctionPrefab, new Vector3 (0f,0f,25.5f),Quaternion.identity));
		hasJunction = true;
		roadCollection.transform.parent = Road.transform;
	}
}
