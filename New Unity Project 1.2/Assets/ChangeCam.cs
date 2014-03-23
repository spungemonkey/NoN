using UnityEngine;
using System.Collections;

public class ChangeCam : MonoBehaviour {

	public Camera currentCamera;
	public Camera nextCamera;
	GameObject camTrigger;
	public string nextLevel = "";
	//this is a comment

	// Use this for initialization
	void Start () {
		currentCamera.enabled = true;
		nextCamera.enabled = false;

		camTrigger = GameObject.Find ("aud_Cheetah");
	
	}
	
	// Update is called once per frame
	void Update () {

		if (!camTrigger.activeInHierarchy) {


			//if (currentCamera == nextCamera)
			//{
			//	Application.LoadLevel(nextLevel);
			//} else {
			currentCamera.enabled = false;
			nextCamera.enabled = true;
			//}
			Debug.Log("Hello Worjguk6kbild");
		}
	}
}
