using UnityEngine;
using System.Collections;

public class GUI_Button_Elephant : MonoBehaviour {

	// Use this for initialization
	public Texture2D butImg = null;
	GameObject ele;
	int i = 0;
	bool but = true;

	void Start () {
		ele = GameObject.Find ("Elephant_Mother");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnGUI()
	{
		if (i >= 16) {
			but = false;
			GUI.enabled = but;
		}

		if (GUI.Button (new Rect (145, Screen.height - 75, butImg.width, butImg.height), butImg) && i<17) 
		{
			//ele.transform.position += new Vector3(1.0f, 0.0f, 1.5f);
			ele.transform.position += new Vector3(1.5f, 0.0f, 0.5f);
			i++;	
		}
	}
}
