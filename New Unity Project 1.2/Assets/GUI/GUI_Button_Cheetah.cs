using UnityEngine;
using System.Collections;

public class GUI_Button_Cheetah : MonoBehaviour {

	// Use this for initialization
	public Texture2D butImg = null;
	GameObject wp = new GameObject();
	GameObject cheetah = new GameObject();
	bool move = false;
	
	void Start () {
		cheetah = GameObject.Find ("Cheetah");
		wp = GameObject.Find ("wp_Cheetah");
		
	}
	
	// Update is called once per frame
	void Update () {

		if (move) {
			cheetah.GetComponent<NavMeshAgent> ().destination = wp.transform.position;
				}
		
	}
	
	private void OnGUI()
	{
		if (GUI.Button (new Rect (210, Screen.height - 75, butImg.width, butImg.height), butImg)) 
		{
			move = true;
			
		}
	}
}
