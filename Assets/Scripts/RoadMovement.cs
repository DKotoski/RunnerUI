using UnityEngine;
using System.Collections;

public class RoadMovement : MonoBehaviour {

	public double Speed;
	public bool Rotation;
	public double newX;
	void Start(){
		Rotation = false;
	}
	void Update () {
		if (!Rotation) {
			gameObject.transform.parent.transform.Translate(new Vector3 (0f, 0f, (float)(-Speed )));
		}
	}


}
