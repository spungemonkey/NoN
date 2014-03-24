using UnityEngine;
using System.Collections;

public class ChangeCam : MonoBehaviour {

	public GameObject trigger;
	public Camera currentCam;
	public Camera nextCam;



	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	if (!trigger.activeInHierarchy && currentCam.camera.enabled){
			currentCam.camera.enabled = false;
			nextCam.camera.enabled = true;
		}
	}
}
