using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GUI_Miner : MonoBehaviour {

	GameObject min1;
	GameObject min2;
	GameObject min3;
	GameObject min4;

	GameObject wp1_3;
	GameObject wp2_4;
	GameObject wp5;
	GameObject wp6;
	GameObject wp7;
	GameObject wp8;

	GameObject[] wp = new GameObject[4];

	public Texture2D butImg = null;

	bool move = false;
	bool enab = true;

	// Use this for initialization
	void Start () {

		min1 = GameObject.Find ("Miner1");
		min1.SetActive(false);
		min2 = GameObject.Find ("Miner2");
		min3 = GameObject.Find ("Miner3");
		min4 = GameObject.Find ("Miner4");


		wp1_3 = GameObject.Find ("wp_1/3");
		wp2_4 = GameObject.Find ("wp_2/4");
		wp5 = GameObject.Find ("wp_5");
		wp6 = GameObject.Find ("wp_6");
		wp7 = GameObject.Find ("wp_7");
		wp8 = GameObject.Find ("wp_8");


		wp [0] = wp5;
		wp [1] = wp6;
		wp [2] = wp7;
		wp [3] = wp8;
		
	
	}
	
	// Update is called once per frame
	void Update () {
		/*
				if (move) {
						min1.GetComponent<NavMeshAgent> ().destination = wp1_3.transform.position;
						min2.GetComponent<NavMeshAgent> ().destination = wp2_4.transform.position;
						//min3.GetComponent<NavMeshAgent> ().destination = wp1_3.transform.position;
						min4.GetComponent<NavMeshAgent> ().destination = wp2_4.transform.position;

						if (min1.transform.position == wp1_3.transform.position ||
								min2.transform.position == wp2_4.transform.position ||
								min3.transform.position == wp1_3.transform.position ||
								min4.transform.position == wp2_4.transform.position) {

								print ("HEY!");

						}
	
				}*/
		}

	void OnGUI(){

		GUI.enabled = enab;
		if (GUI.Button (new Rect (15, Screen.height - 75, butImg.width, butImg.height), butImg)){
			move = true;
			min1.SetActive(true);
			
			enab = false;
		}
	}
}
