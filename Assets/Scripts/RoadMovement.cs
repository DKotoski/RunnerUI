using UnityEngine;
using System.Collections;

public class RoadMovement : MonoBehaviour {

	public double Speed;
	public bool Rotation;
	public double newX;
	void Start(){
		Rotation = false;
		newX = 0f;
	}
	void Update () {
		if (!Rotation) {
			var posZ = gameObject.transform.position.z;
			gameObject.transform.position = new Vector3 (0f, 0f, (float)(posZ - Speed));
		}
	}


}
