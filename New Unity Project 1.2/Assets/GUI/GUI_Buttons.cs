using UnityEngine;
using System.Collections;

public class GUI_Buttons : MonoBehaviour {

	GameObject sun;
	public Texture2D butImg = null;

	Vector3 startPos;
	public Vector3 endPos;
	public float timeMultiplier = 15.0f;
	float time;
	public bool isLerp;
	public AudioClip cymbal;

	bool isSun = false;

	bool guiEnabled = true;

	// Use this for initialization
	void Start () {
		sun = GameObject.Find ("Sun");
		startPos = sun.transform.position;
		isLerp = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!isSun) {
			time = 0;
				}
		if (isSun) {
			time += Time.deltaTime / timeMultiplier;
						if (!isLerp) {
								sun.transform.position = Vector3.Slerp (startPos, endPos, time);
						} else {
								sun.transform.position = Vector3.Lerp (startPos, endPos, time);
						}
				}
	}

	private void OnGUI()
	{
		if (!guiEnabled) {
						GUI.enabled = guiEnabled;
				}
		
		if (GUI.Button (new Rect (15, Screen.height - 75, butImg.width, butImg.height), butImg) && GUI.enabled) 
		{
			isSun = true;
			audio.clip = cymbal;
			audio.Play();	
			guiEnabled = false;
		}
	}
}
