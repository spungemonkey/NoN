using UnityEngine;
using System.Collections;

public class GUI_Elephant : MonoBehaviour {
	
	GameObject elephant;
	public Texture2D butImg = null;
	bool enab = true;
	
	// Use this for initialization
	void Start () {
		
		elephant = GameObject.Find ("Elephant_Mother");
		elephant.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI(){
		
		GUI.enabled = enab;
		if (GUI.Button (new Rect (145, Screen.height - 75, butImg.width, butImg.height), butImg)){
			
			elephant.SetActive(true);
			enab = false;
		}
	}
}
