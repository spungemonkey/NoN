using UnityEngine;
using System.Collections;

public class GUI_Button_Tok : MonoBehaviour {

	GameObject tok;

	public Texture2D butImg = null;
	bool enab = true;
	

	// Use this for initialization
	void Start () {


		tok = GameObject.Find ("Bug");
		tok.SetActive(false);	
	
	}
	
	// Update is called once per frame
	void Update () {
	}



	private void OnGUI()
	{
			GUI.enabled = enab;
		if (GUI.Button (new Rect (80, Screen.height - 75, butImg.width, butImg.height), butImg)) 
		{
			tok.SetActive(true);
			enab = false;
		}
	}
}
