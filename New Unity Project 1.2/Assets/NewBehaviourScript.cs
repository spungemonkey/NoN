using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public Texture2D butImg1;
	public Texture2D butImg2;
	public Texture2D butImg3;
	public Texture2D butImg4;
	public Texture2D butImg5;
	float butPos1;
	float butPos2;
	float butPos3;
	float butPos4;
	float butPos5;
	// Use this for initialization
	void Start () {

		butPos1 = 100;
		butPos2 = butPos1 + 65;
		butPos3 = butPos2 + 65;
		butPos4 = butPos3 + 65;
		butPos5 = butPos4 + 65;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.Button (new Rect (butPos1, Screen.height / 2 + 30, butImg1.width, butImg1.height), butImg1);
		GUI.Button (new Rect (butPos2, Screen.height / 2 + 30, butImg2.width, butImg2.height), butImg2);
		GUI.Button (new Rect (butPos3, Screen.height / 2 + 30, butImg3.width, butImg3.height), butImg3);
		GUI.Button (new Rect (butPos4, Screen.height / 2 + 30, butImg4.width, butImg4.height), butImg4);
		GUI.Button (new Rect (butPos5, Screen.height / 2 + 30, butImg5.width, butImg5.height), butImg5);

		}
}
