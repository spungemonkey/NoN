using UnityEngine;
using System.Collections;

public class Temp_Narrator : MonoBehaviour {


	public GameObject[] obj;
	public AudioClip[] ac;
	
	public Texture2D butImg = null;
	bool enab = true;
	int aClip;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (obj[0].name);
		if (!obj [0].activeInHierarchy) {
			aClip = 0;
				}
		if (!obj [1].activeInHierarchy) {
			aClip = 1;
		}
		if (!obj [2].activeInHierarchy) {
			aClip = 2;
		}
		if (!obj [3].activeInHierarchy) {
			aClip = 3;
		}
		if (!obj [4].activeInHierarchy) {
			aClip = 4;
		}
	
	}


	void OnGUI(){
		if (GUI.Button (new Rect (15, 15, butImg.width, butImg.height), butImg) && !audio.isPlaying) {
			audio.clip = ac[aClip];
			audio.Play();
				}
	}
}
