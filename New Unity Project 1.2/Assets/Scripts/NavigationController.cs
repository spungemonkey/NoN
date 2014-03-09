using UnityEngine;
using System.Collections;

public class NavigationController : MonoBehaviour {

	//Waypoints
	public GameObject[] Waypoints;
	public NavMeshAgent navMesh;
	int currentWaypoint=0;
	public string WaypointTagName="Waypoint";

	// Use this for initialization
	void Start () {
		navMesh=GetComponent<NavMeshAgent>();
		navMesh.destination=Waypoints[currentWaypoint].transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentWaypoint>Waypoints.Length)
		{ 
		}
		else{
				navMesh.destination=Waypoints[currentWaypoint].transform.position;
		}

		Collider[] colliders=Physics.OverlapSphere(transform.position,2.0f);
		foreach(Collider c in colliders)
		{
			if (c.gameObject.tag==WaypointTagName)
			{
				Destroy(c.gameObject);
				Debug.Log("Hit Waypoint");
				currentWaypoint++;
				if (currentWaypoint>Waypoints.Length)
				{
				}
				else{
					navMesh.destination=Waypoints[currentWaypoint].transform.position;
				}
			}
		}
	
	}
}
