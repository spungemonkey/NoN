using UnityEngine;
using System.Collections;

public class GUI_Cheetah : MonoBehaviour {

	GameObject cheetah;
	public Texture2D butImg = null;
	bool enab = true;

	// Use this for initialization
	void Start () {

		cheetah = GameObject.Find ("Cheetah");
		cheetah.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		
		GUI.enabled = enab;
		if (GUI.Button (new Rect (210, Screen.height - 75, butImg.width, butImg.height), butImg)){
			
			cheetah.SetActive(true);
			enab = false;
		}
	}
}
