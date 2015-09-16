using UnityEngine;
using System.Collections;

public class RoadDestroyer : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		Destroy (other.gameObject);
	}
}
