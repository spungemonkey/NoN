using UnityEngine;
using System.Collections;

public class GUI_Button : MonoBehaviour {

	public GameObject[] obj;
	public GameObject trigger;
	public GameObject nextTrigger;
	public Texture2D butImg;
	public Texture2D butImg2;
	public AudioClip ac;
	public AudioClip ac2;
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

		if (!trigger.activeInHierarchy) {
						if (GUI.Button (new Rect (butPos, Screen.height / 2, butImg.width, butImg.height), butImg) && !trigger.activeInHierarchy) {

								for (int i=0; i < obj.Length; i++) {
										obj [i].SetActive (true);
								}
								audio.clip = ac;
								audio.Play ();
								//guiEnabled = false;
								nextTrigger.SetActive (false);
								butImg = null;
								butImg2 = null;

						}

						if (GUI.Button (new Rect (butPos + 65, Screen.height / 2, butImg2.width, butImg2.height), butImg2)) {
								audio.clip = ac2;
								audio.Play ();
						}

				}


	}
}
