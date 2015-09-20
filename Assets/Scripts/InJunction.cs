using UnityEngine;
using System.Collections;

public class InJunction : MonoBehaviour {

    public GameObject GameWorld;

    void Start()
    {
        GameWorld = GameObject.Find("RoadCollection");
    }

	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "Player") {		
			Rotate();
			}
	}

	void Rotate(){
        GameWorld.transform.RotateAround(GameObject.Find("Player").transform.position, Vector3.up, 90f);
	}

	void OnDestroy(){
		GameObject.Find("RoadSpawner").GetComponent<RoadSpawner>().hasJunction = false;
	}

}
