using UnityEngine;
using System.Collections;

public class GUI_Button_Tok : MonoBehaviour {

	public Texture2D butImg = null;

	Vector3 startPos;
	public Vector3 endPos;
	GameObject[] waypoint = new GameObject[5];
	GameObject tok = new GameObject();
	
	public float timeMultiplier = 15.0f;
	Vector3 currentPos;
	float time;
	int i;
	GameObject bug = null;
	public AudioClip tok_audio;

	bool follow = false;
	

	// Use this for initialization
	void Start () {


		startPos = this.transform.position; //1, 0.2, -11
		tok = GameObject.Find ("Tok");

		waypoint[0] = GameObject.Find ("wp_Bug0");
		waypoint[1] = GameObject.Find ("wp_Bug1");
		waypoint[2] = GameObject.Find ("wp_Bug2");
		waypoint[3] = GameObject.Find ("wp_Bug3");
		waypoint[4] = GameObject.Find ("wp_Bug4");

		i = 0;
		bug = GameObject.Find ("Bug");
	
	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime / timeMultiplier;
		currentPos = bug.transform.position;
		
		//if (currentPos != waypoint [i]) {
		if (currentPos != waypoint [i].transform.position) {
			//movement (currentPos, waypoint [i], time);
			movement (currentPos, waypoint[i].transform.position, time);
		} 
	}
	
	
	
	
	void movement(Vector3 cPos, Vector3 way, float t){
		Vector3 wp = way;
		Vector3 current = cPos;
		
		bug.transform.position = Vector3.Lerp (current, wp, t);
		
	}


	private void OnGUI()
	{
		if (GUI.Button (new Rect (80, Screen.height - 75, butImg.width, butImg.height), butImg)) 
		{
			if (i < waypoint.Length - 1)
			{
				i++;
				audio.clip = tok_audio;
				audio.Play();
			}
		}
	}
}
