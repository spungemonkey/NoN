using UnityEngine;
using System.Collections;

public class testswitch : MonoBehaviour {

	bool buttonPressed = false;
	public float updateTime = 1.0f;
	float currentTime = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Fire1") && !buttonPressed)
		{
			Debug.Log("Button Pressed");
			buttonPressed=true;
		}
		
		if (buttonPressed)
		{
			currentTime+=Time.deltaTime;
			if (currentTime>updateTime)
			{
				buttonPressed=false;
				currentTime=0.0f;
			}
		}
	
	}
}
