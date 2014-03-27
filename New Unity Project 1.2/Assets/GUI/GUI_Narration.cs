using UnityEngine;
using System.Collections;

public class GUI_Narration : MonoBehaviour {


	public GameObject trigger;
	public GameObject endTrigger;
	public AudioClip ac;
	public Texture2D butImg;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (!endTrigger.activeInHierarchy || endTrigger == null) {
			butImg = null;		
		}
	
	}


	void OnGUI(){

		if (GUI.Button (new Rect (20, 20, butImg.width, butImg.height), butImg) &&
		   !trigger.activeInHierarchy ) {
			if (!audio.isPlaying)
			{
			audio.clip = ac;
			audio.Play ();
			} else {
				//do nothing
			}


		}
	}
}
