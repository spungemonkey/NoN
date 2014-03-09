using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GUI_Miner : MonoBehaviour {

	GameObject min1;
	GameObject min2;
	GameObject min3;
	GameObject min4;

	public Texture2D butImg = null;

	bool move = false;
	bool enab = true;

	// Use this for initialization
	void Start () {

		min1 = GameObject.Find ("Miner1");
		min1.SetActive(false);
		min2 = GameObject.Find ("Miner2");
		min2.SetActive(false);
		min3 = GameObject.Find ("Miner3");
		min3.SetActive(false);
		min4 = GameObject.Find ("Miner4");
		min4.SetActive(false);

	
	}
	
	// Update is called once per frame
	void Update () {

		}

	void OnGUI(){

		GUI.enabled = enab;
		if (GUI.Button (new Rect (15, Screen.height - 75, butImg.width, butImg.height), butImg)){
			move = true;
			min1.SetActive(true);
			min2.SetActive(true);
			min3.SetActive(true);
			min4.SetActive(true);
			
			enab = false;
		}
	}
}
