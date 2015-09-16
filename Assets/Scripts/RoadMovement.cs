using UnityEngine;
using System.Collections;

public class RoadMovement : MonoBehaviour {

	public double Speed;
	void Update () {
		var posZ = gameObject.transform.position.z;
		gameObject.transform.position = new Vector3 (0f, 0f, (float)(posZ - Speed));
	}
}
