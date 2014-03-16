using UnityEngine;
using System.Collections;

public class GUI_Narration : MonoBehaviour {

	public GameObject obj;
	public GameObject obj2;

	public AudioClip ac;
	public AudioClip ac2;
	public AudioClip ac3;

	public Texture2D butImg = null;
	bool enab = true;
	int aClip = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (aClip);
		if (obj == null) {
						aClip = 1;
				}
		if (obj2 == null) {
			aClip = 2;		
		}



	}

	void OnGUI(){

		if (GUI.Button (new Rect (15, 15, butImg.width, butImg.height), butImg) && !audio.isPlaying){
			Debug.Log("Hello");

			//if (audio.isPlaying == false)
			//{

				switch (aClip)
				{
				case 0:
					audio.clip = ac;
					audio.Play();
					break;
				case 1:
					audio.clip=ac2;
					audio.Play();
					break;
				case 2:
					audio.clip=ac3;
					audio.Play();
					break;
				default:
					audio.clip=ac;
					audio.Play();
					break;
				}
			//}
		}
	}

}
