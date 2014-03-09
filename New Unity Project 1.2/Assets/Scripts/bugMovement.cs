using UnityEngine;
using System.Collections;

public class bugMovement : MonoBehaviour {
	
	// Use this for initialization
	
	Vector3 startPos;
	public Vector3 endPos;

	public Vector3[] waypoint = new Vector3[5];

	public float timeMultiplier = 15.0f;
	Vector3 currentPos;
	float time;
	int i;

	
	void Start () {
		
		startPos = this.transform.position; //1, 0.2, -11
		waypoint[0] = new Vector3 (-0.5f, 0.2f, -8.0f);
		waypoint[1] = new Vector3 (-0.08f, 0.2f, -5.3f);
		waypoint[2] = new Vector3 (-0.06f, 0.2f, -4.2f);
		waypoint[3] = new Vector3 (-1.9f, 0.2f, 0.3f);
		waypoint[4] = new Vector3 (-0.14f, 0.2f, 2.2f);
		i = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime / timeMultiplier;
		currentPos = this.transform.position;

		if (currentPos != waypoint [i]) {
						movement (currentPos, waypoint [i], time);
				} 
//		else {
//						if (i == waypoint.Length - 1) {
//				//do nothing
//						} else {
//								i++;
//						}
//				}
	}


	
	
	void movement(Vector3 cPos, Vector3 way, float t){
		Vector3 wp = way;
		Vector3 current = cPos;
		
		transform.position = Vector3.Lerp (current, wp, t);
		
	}
	
}