using UnityEngine;
using System.Collections;

public class GUI_Kids : MonoBehaviour {

	GameObject kid1;
	GameObject kid2;
	GameObject kid3;
	GameObject kid4;

	public Texture2D butImg = null;
	bool enab = true;

	// Use this for initialization
	void Start () {


		kid1 = GameObject.Find ("Kid1");
		kid1.SetActive(false);	
		kid2 = GameObject.Find ("Kid2");
		kid2.SetActive(false);
		kid3 = GameObject.Find ("Kid3");
		kid3.SetActive(false);
		kid4 = GameObject.Find ("Kid4");
		kid4.SetActive(false);

	
	}
	
	// Update is called once per frame
	void Update () {

		}

	void OnGUI(){

		GUI.enabled = enab;
		if (GUI.Button (new Rect (80, Screen.height - 75, butImg.width, butImg.height), butImg)){

			kid1.SetActive(true);
			kid2.SetActive(true);
			kid3.SetActive(true);
			kid4.SetActive(true);
			
			enab = false;
		}
	}
}
