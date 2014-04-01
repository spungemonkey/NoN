using UnityEngine;
using System;
using System.IO;
using System.Text;
using System.Collections;
//using UnityEditor;

public class Analytics : MonoBehaviour {

	public Texture2D butImg;
	float butX;
	float butY;
	float butZ;
	public GameObject scene;

	bool buttonPressed = false;

	public float updateTime = 1.0f;
	float currentTime = 0.0f;
	
	string path;
	int clicknum = 0;
	int switchnum = 0;
	string output;
	string extension;
	string moscoords;
	string sceneDetails;
	string screenDetails;
	string isMouse;
	string isSwitch;

	string evalContent;

	// Use this for initialization
	void Start () {
		butX = Screen.width / 2 - butImg.width;
		butY = Screen.height + 30;
		butZ = butX + 65;
		output = "Eval.txt";
		extension = ".txt";
		isMouse = "m";
		isSwitch = "s";

		
		sceneDetails = scene.name;
		screenDetails = "Aspect Ratio: " + Screen.width + "x" + Screen.height + "\nButton 1 Position: " + butX + ", " + butY + " Button 2 Position: " + butZ + ", " + butY;

		//Debug.Log (Application.persistentDataPath);
		//path = Application.persistentDataPath + output;
		
	}
	
	// Update is called once per frame
	void Update () {

		output = "Eval.txt";
		extension = ".txt";
		isMouse = "m";
		isSwitch = "s";


			if (Input.GetMouseButtonDown(0))
			{
				path = Application.dataPath + "_" + "_" + isMouse + "_" + sceneDetails + "_" + clicknum.ToString() + output;
				moscoords = Input.mousePosition.ToString();
				evalContent = sceneDetails + "\n" + screenDetails + "\n" + moscoords;
				clicknum++;
			}

			if (Input.GetButtonDown("Fire1") && 
			    !buttonPressed)
			{
				buttonPressed = true;
				path = Application.dataPath + "_" + "_" + isSwitch + "_" + sceneDetails + "_" + switchnum.ToString() + output;
				evalContent = sceneDetails + "\n" + screenDetails + "\nCorrect";
				switchnum++;
			}

			if (Input.GetButtonDown("Fire2") && 
			    !buttonPressed)
			{
				buttonPressed = true;
				path = Application.dataPath + "_" + "_" + isSwitch + "_" + sceneDetails + "_" + switchnum.ToString() + output;
				evalContent = sceneDetails + "\n" + screenDetails + "\nMissed";
				switchnum++;
				
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




			using(FileStream fs = File.Create(path)){
				AddText(fs, evalContent);
			}
	}

	private static void AddText(FileStream fs, string value){
		byte[] info = new UTF8Encoding (true).GetBytes (value);
		fs.Write (info, 0, info.Length);

	}
}
