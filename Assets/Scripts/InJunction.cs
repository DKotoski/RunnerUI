using UnityEngine;
using System.Collections;

public class InJunction : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "Player") {		
			Rotate();
			}
	}

	void Rotate(){
		var Z = gameObject.transform.parent.transform.parent.transform.position.z;
		gameObject.transform.parent.transform.parent.RotateAround(new Vector3(0f,100f,0f),Vector3.up,90f);
		gameObject.transform.parent.transform.parent.position = new Vector3 (-Z, 0f, 0f);
	}
}
