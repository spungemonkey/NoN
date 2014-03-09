using UnityEngine;
using System.Collections;

public class ChangeCam : MonoBehaviour {

	GameObject main;// = new GameObject();
	GameObject second;// = new GameObject();
	// Use this for initialization
	void Start () {

		main = GameObject.Find ("Main Camera");
		second = GameObject.Find ("Second_Cam");
		main.camera.active = true;
		second.camera.active = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (2)) 
		{
			main.camera.active = !main.camera.active;
			second.camera.active = !second.camera.active;
		}

	}
}
