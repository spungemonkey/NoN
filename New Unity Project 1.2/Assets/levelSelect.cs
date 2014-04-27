using UnityEngine;
using System.Collections;

public class levelSelect : MonoBehaviour {

	public string[] levels;
	int pos = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		//GUI.Button (new Rect (butPos1, Screen.height / 2 + 30, butImg1.width, butImg1.height), butImg1);
		if (GUI.Button (new Rect (Screen.width / 2, pos, 200, 75), "0. Introduction")) {
			Application.LoadLevel(levels[0]);
			}
		if (GUI.Button (new Rect (Screen.width / 2, pos + 100, 200, 75), "1. Waterfront")) {
			Application.LoadLevel(levels[1]);
		}
		if (GUI.Button (new Rect (Screen.width / 2, pos + 200, 200, 75), "3. Village")) {
			Application.LoadLevel(levels[2]);
		}
		if (GUI.Button (new Rect (Screen.width / 2, pos + 300, 200, 75), "4. Desert")) {
			Application.LoadLevel(levels[3]);
		}
		if (GUI.Button (new Rect (Screen.width / 2, pos + 400, 200, 75), "5. Waterfront")) {
			Application.LoadLevel(levels[4]);
		}
		if (GUI.Button (new Rect (Screen.width / 2, pos + 500, 200, 75), "6. Village")) {
			Application.LoadLevel(levels[5]);
		}
		if (GUI.Button (new Rect (Screen.width / 2, pos + 600, 200, 75), "7. Desert")) {
			Application.LoadLevel(levels[6]);
		}
	}
}
