using UnityEngine;
using System.Collections;

public class GUI_Cam3 : MonoBehaviour {

	// Use this for initialization
	const bool guiEnabled = false;
	public Texture2D butImg = null;
	public Texture2D butImg2 = null;
	public Texture2D butImg3 = null;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnGUI(){
		
		GUI.enabled = guiEnabled;
		
		GUI.Button (new Rect (15, Screen.height - 75, butImg.width, butImg.height), butImg);
		GUI.Button (new Rect (80, Screen.height - 75, butImg.width, butImg.height), butImg2);
		GUI.Button (new Rect (210, Screen.height - 75, butImg.width, butImg.height), butImg3);
		
	}

}
