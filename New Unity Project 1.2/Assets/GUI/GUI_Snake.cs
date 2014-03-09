using UnityEngine;
using System.Collections;

public class GUI_Snake : MonoBehaviour {

	GameObject snake;
	public Texture2D butImg = null;
	bool enab = true;
	bool snakebool = false;
	
float amplitudeZ = -22.0f;

float omegaZ = -4.0f;
float index;

	// Use this for initialization
	void Start () {
		
		snake = GameObject.Find ("Snake");
		snake.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (snakebool)
		{
			/* index += Time.deltaTime;
			
			float z = -(Mathf.Abs (amplitudeZ*Mathf.Sin (omegaZ*index)));
			if (z > -18.0f)
			{
			z = -18.5f;
			} else if (z < -22.0f){
			z = -21.0f;
			} else {
			}
			print(z);
			snake.transform.position.z = z; */
		}
	}
	
	void OnGUI(){
		GUI.enabled = enab;
		if (GUI.Button (new Rect (15, Screen.height - 75, butImg.width, butImg.height), butImg))
		{
			snake.SetActive(true);
			snakebool = true;
			enab = false;
		}
	}
}
