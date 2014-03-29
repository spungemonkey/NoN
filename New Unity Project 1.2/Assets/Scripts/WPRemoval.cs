using UnityEngine;
using System.Collections;

public class WPRemoval : MonoBehaviour {

	public GameObject[] Waypoints;
	public string WaypointTagName="Waypoint";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Collider[] colliders=Physics.OverlapSphere(transform.position,2.0f);
		foreach(Collider c in colliders)
		{
			if (c.gameObject.tag==WaypointTagName)
			{
				if (c.gameObject !=null)
				{
					//Destroy(c.gameObject);
					c.gameObject.SetActive(false);
				}
			}
		}
	
	}
}
