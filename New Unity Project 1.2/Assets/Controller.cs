using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.JoystickButton0)) {
						Debug.Log ("0");
				}

		if (Input.GetKey (KeyCode.JoystickButton1)) {
			Debug.Log ("1");
		}

		}

	}
