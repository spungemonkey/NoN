using UnityEngine;
using System.Collections;

public class MoveModel : MonoBehaviour {
	
	
	
	Vector3 startPos;
	public Vector3 endPos;
	public float timeMultiplier = 15.0f;
	float time;
	public bool isLerp;
	
	
	// Use this for initialization
	void Start () {
		
		startPos = this.transform.position;
		isLerp = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		time += Time.deltaTime / timeMultiplier;

		if (!isLerp) {
						transform.position = Vector3.Slerp(startPos, endPos, time);
				} else {
						transform.position = Vector3.Lerp (startPos, endPos, time);
				}
	}
}