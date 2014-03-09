using UnityEngine;
using System.Collections;

public class GUI_Scorpion : MonoBehaviour {

	GameObject scorp;
	public Texture2D butImg = null;
	bool enab = true;
	// Use this for initialization
	void Start () {
		
		scorp = GameObject.Find ("Scorpion");
		scorp.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI(){
		GUI.enabled = enab;
		if (GUI.Button (new Rect (80, Screen.height - 75, butImg.width, butImg.height), butImg))
		{
			scorp.SetActive(true);
			enab = false;
		}
	}
}
