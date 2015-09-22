using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour {

	public double speed;

	public double[] postitions = new double[4];
	int current;
	// Use this for initialization
	void Start () {
		current = 1;
	}
	
	// Update is called once per frame
	void Update () {

			float input = Input.GetAxis ("Horizontal");
			if (Input.GetKeyUp(KeyCode.RightArrow)) {
				GoRight ();

		} else if (Input.GetKeyUp(KeyCode.LeftArrow	)) {
				GoLeft ();
				
			}

			Debug.Log (postitions [current]);
			Debug.Log (current);
	
	}

	void GoRight(){
		if (current >= 3)
			return;
		current++;
		MoveTo (postitions [current]);

	}
	void GoLeft(){
		if (current <= 0)
			return;
		current--;
		MoveTo (postitions [current]);
	}

	void MoveTo(double location){
		gameObject.transform.localPosition=new Vector3 ((float)location, -4f, 21.8f);
	}

}
