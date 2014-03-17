using UnityEngine;
using System.Collections;

public class GUI_Narration : MonoBehaviour {

	//public GameObject obj;
	//public GameObject obj2;

//	public AudioClip awc;
//	public AudioClip ac2;
//	public AudioClip ac3;


	public GameObject[] obj;
	public AudioClip[] ac;

	public Texture2D butImg = null;
	bool enab = true;
	int aClip = 0;

	// Use this for initialization
	void Start () {

		audio.clip = ac [0];

	}
	
	// Update is called once per frame
	void Update () {
	
//		for (int i = 0; i < obj.Length; i++) {
//					if (obj[i] == null){
//				audio.clip = ac[i];
//			}
//				}



//		Debug.Log (aClip);
//		if (obj == null) {
//						aClip = 1;
//				}
//		if (obj2 == null) {
//			aClip = 2;		
//		}



	}

	void OnGUI(){

		if (GUI.Button (new Rect (15, 15, butImg.width, butImg.height), butImg) && !audio.isPlaying){
			Debug.Log("Hello");


			audio.Play();
//
//				switch (aClip)
//				{
//				case 0:
//					audio.clip = ac;
//					audio.Play();
//					break;
//				case 1:
//					audio.clip=ac2;
//					audio.Play();
//					break;
//				case 2:
//					audio.clip=ac3;
//					audio.Play();
//					break;
//				default:
//					audio.clip=ac;
//					audio.Play();
//					break;
//				}


		}
	}

}
