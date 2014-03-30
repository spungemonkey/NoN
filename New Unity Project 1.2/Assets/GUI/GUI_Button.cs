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
	public float accelerator = 1.0f;
	int j = 0;
	bool playAudio;

	int butPos;

	Input mainSwitch;
	Input secondarySwitch;
	Input lastSwitch;

	bool guiEnabled = true;

	bool buttonPressed = false;
	public float updateTime = 1.0f;
	float currentTime = 0.0f;
	float audioTime = 0.0f;



	// Use this for initialization
	void Start () {


		for (int i=0; i < obj.Length; i++) 
		{
			obj[i].SetActive(false);
		}
		butPos = Screen.width / 2 - butImg.width;
		playAudio = false;
		//j = 0;

	}
	
	// Update is called once per frame
	void Update () {

		if (playAudio) {
			if (!audio.isPlaying && j <= ac.Length){
				audio.clip = ac [j];
				audio.Play ();
				//j = j + 1;
				++j;
			}
			if (j >= ac.Length){
				audioTime+=Time.deltaTime;

				if (audioTime>audio.clip.length-accelerator)
				{
					nextTrigger.SetActive(false);
					j = 0;
					playAudio = false;
					audio.clip = null;
				}
			}

			print (audioTime);
			print (audio.clip.length);
		}


		if (Input.GetButtonDown("Fire1") && 
		    !buttonPressed)
		{
			buttonPressed = true;
			ButtonTrigger();
		}
		
		if (buttonPressed)
		{
			currentTime+=Time.deltaTime;
			if (currentTime>updateTime)
			{
				buttonPressed=false;
				currentTime=0.0f;
			}
		}
	}



	void OnGUI(){

		if (!trigger.activeInHierarchy) {
						if (GUI.Button (new Rect (butPos, Screen.height / 2 + 30, butImg.width, butImg.height), butImg) && 
						!trigger.activeInHierarchy) {
							ButtonTrigger();
						}

						if (GUI.Button (new Rect (butPos + 65, Screen.height / 2 + 30, butImg2.width, butImg2.height), butImg2) ||
						Input.GetKey(KeyCode.JoystickButton1)) {
							WrongButton();
						}

				}
	}

	void ButtonTrigger(){

		for (int i=0; i < obj.Length; i++) {
			obj [i].SetActive (true);
		}
		playAudio = true;
	//	nextTrigger.SetActive (false);
		butImg = null;
		butImg2 = null;
		buttonPressed=true;

	}

	void WrongButton(){
		audio.clip = ac2;
		audio.Play ();
	}
	
}
