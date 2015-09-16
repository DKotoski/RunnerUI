using UnityEngine;
using System.Collections;

public class InJunction : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "Player") {		
			Rotate();
			gameObject.transform.parent.transform.parent.position = new Vector3 (-40f, 0f, 5f);
			gameObject.transform.parent.transform.parent.position = new Vector3 (-40f, 0f);
			}
	}

	void Rotate(){

		var Z = gameObject.transform.parent.transform.parent.transform.position.z;
		Debug.Log (gameObject.transform.parent.transform.parent.name);

		gameObject.transform.parent.transform.parent.rotation = Quaternion.Euler(0, 90, 0);
		//gameObject.transform.parent.transform.parent.RotateAround(new Vector3(0f,0f,0f),Vector3.up,90f);

		var X = gameObject.transform.parent.transform.parent.transform.position.x;	


	}

	void OnDestroy(){
		GameObject.Find ("RoadSpawner").GetComponent<RoadSpawner> ().hasJunction = false;
	}
}
