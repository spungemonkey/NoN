using UnityEngine;
using System.Collections;

public class GUI_Button : MonoBehaviour {

	public GameObject[] obj;
	public GameObject trigger;
	public GameObject nextTrigger;
	public Texture2D butImg;
	public Texture2D butImg2;
	public AudioClip[] ac;
	public AudioClip ac2;
	int j;
	bool playAudio;

	int butPos;

	Input mainSwitch;
	Input secondarySwitch;
	Input lastSwitch;

	bool guiEnabled = true;

	// Use this for initialization
	void Start () {


		for (int i=0; i < obj.Length; i++) 
		{
			obj[i].SetActive(false);
		}
		butPos = Screen.width / 2 - butImg.width;
		playAudio = false;
		j = 0;
		//mainSwitch = Input.GetKeyDown (KeyCode.JoystickButton0);
		//secondarySwitch = Input.GetKeyDown (KeyCode.JoystickButton1);
	}
	
	// Update is called once per frame
	void Update () {

		if (playAudio) {
			if (!audio.isPlaying && j < ac.Length){
				audio.clip = ac [j];
				audio.Play ();
				j = j + 1;
			}
			if (j >= ac.Length){
				j = 0;
				playAudio = false;
			}
				}
	
	}



	void OnGUI(){

		if (!trigger.activeInHierarchy) {
						if (GUI.Button (new Rect (butPos, Screen.height / 2 + 30, butImg.width, butImg.height), butImg) && 
						!trigger.activeInHierarchy ||
						Input.GetKey(KeyCode.JoystickButton0) &&
			    		!trigger.activeInHierarchy) { 			//untested


								for (int i=0; i < obj.Length; i++) {
										obj [i].SetActive (true);
								}
								playAudio = true;
								nextTrigger.SetActive (false);
								butImg = null;
								butImg2 = null;
								
						}

						if (GUI.Button (new Rect (butPos + 65, Screen.height / 2 + 30, butImg2.width, butImg2.height), butImg2) ||
						Input.GetKey(KeyCode.JoystickButton1)) { 	//untested
								audio.clip = ac2;
								audio.Play ();
						}

				}


	}
}
