using UnityEngine;
using System.Collections;

public class GUI_Sun : MonoBehaviour {

	public GameObject sun;
	public Texture2D butImg = null;
	bool enab = true;

	// Use this for initialization
	void Start () {

		sun = GameObject.Find ("Sun_Container");
		sun.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	void OnGUI(){
		
		GUI.enabled = enab;
		if (GUI.Button (new Rect (15, Screen.height - 75, butImg.width, butImg.height), butImg)){
			
			sun.SetActive(true);
			enab = false;
		}
	}
}