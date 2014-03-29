using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	public GameObject trigger;
	public string nextLevel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if (!trigger.activeInHierarchy) {
		if (trigger == null || !trigger.activeInHierarchy){
			Application.LoadLevel(nextLevel);
			Debug.Log("This is the level");
				}
	}
}
