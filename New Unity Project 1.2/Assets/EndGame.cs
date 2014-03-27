using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

	public GameObject trigger;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (!trigger.activeInHierarchy || trigger == null)
		{
			Application.Quit();
		}
	
	}
}
