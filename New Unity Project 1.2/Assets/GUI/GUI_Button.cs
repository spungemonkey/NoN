using UnityEngine;
using System.Collections;

public class GUI_Button : MonoBehaviour {

	public GameObject[] obj;
	public GameObject trigger;
	public GameObject nextTrigger;
	public Texture2D butImg;
	public AudioClip ac;
	public int butPos;

	bool guiEnabled = true;

	// Use this for initialization
	void Start () {


		for (int i=0; i < obj.Length; i++) 
		{
			obj[i].SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){

		GUI.enabled = guiEnabled;

		if (GUI.Button (new Rect (butPos, Screen.height - 75, butImg.width, butImg.height), butImg) && !trigger.activeInHierarchy){
			for (int i=0; i < obj.Length; i++) 
			{
				obj[i].SetActive(true);
			}
			audio.clip = ac;
			audio.Play ();
			guiEnabled = false;
			nextTrigger.SetActive(false);
		}
	}
}
