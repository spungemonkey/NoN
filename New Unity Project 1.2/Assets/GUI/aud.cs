using UnityEngine;
using System.Collections;

public class aud : MonoBehaviour {

	public Texture2D butImg;
	public AudioClip[] ac;
	int count = 0;
	bool playNow = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playNow) {
						if (!audio.isPlaying && count < ac.Length) {
								audio.clip = ac [count];
								audio.Play ();
								count = count + 1;
						}
			if (count >= ac.Length){
				count = 0;
				playNow = false;
			}
				}
		
	}

	void myAud(){

	}
	
	void OnGUI(){
		if (GUI.Button (new Rect (20, 20, butImg.width, butImg.height), butImg)) {

			playNow = true;
		}
	}

}
