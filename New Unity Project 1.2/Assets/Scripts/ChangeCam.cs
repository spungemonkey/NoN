using UnityEngine;
using System.Collections;

public class ChangeCam : MonoBehaviour {

	public GameObject trigger;
	public Camera currentCam;
	public Camera nextCam;



	// Use this for initialization
	void Start () {

		currentCam.camera.enabled = true;
		nextCam.camera.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

	if (!trigger.activeInHierarchy && currentCam.camera.enabled || trigger == null && currentCam.camera.enabled){
			//currentCam.camera.enabled = false;
			//nextCam.camera.enabled = true;

			currentCam.camera.enabled = !currentCam.enabled;
			nextCam.camera.enabled = !nextCam.enabled;
		}
	}
}
