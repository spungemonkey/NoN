using UnityEngine;
using System.Collections;

public class NavigationController : MonoBehaviour {

	//Waypoints
	public GameObject[] Waypoints;
	public NavMeshAgent navMesh;
	int currentWaypoint=0;
	public int wait;
	public string WaypointTagName="Waypoint";
	int timer = 10;

	// Use this for initialization
	void Start () {
		navMesh=GetComponent<NavMeshAgent>();
		navMesh.destination=Waypoints[currentWaypoint].transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (currentWaypoint>=Waypoints.Length)
		{ 
			currentWaypoint=Waypoints.Length;
		} else{
			navMesh.destination=Waypoints[currentWaypoint].transform.position;
		}
		int t = wpTime;
		t--;
		Collider[] colliders=Physics.OverlapSphere(transform.position,2.0f);
		foreach(Collider c in colliders)
		{
			if (c.gameObject.tag==WaypointTagName)
			{
				

				Debug.Log(t);
				if (t <= 0)
				{
				Destroy(c.gameObject);
					currentWaypoint++;
					timer=10;
				}
				if (currentWaypoint>=Waypoints.Length)
				{
					currentWaypoint=Waypoints.Length;
				} else{
					navMesh.destination=Waypoints[currentWaypoint].transform.position;
				}
			}
		}
	
	}
	
	void moveWaypoints(int wpTime){
		if (currentWaypoint>=Waypoints.Length)
		{ 
			currentWaypoint=Waypoints.Length;
		} else{
			navMesh.destination=Waypoints[currentWaypoint].transform.position;
		}
		int t = wpTime;
		t--;
		Collider[] colliders=Physics.OverlapSphere(transform.position,2.0f);
		foreach(Collider c in colliders)
		{
			if (c.gameObject.tag==WaypointTagName)
			{
				

				Debug.Log(t);
				if (t <= 0)
				{
				Destroy(c.gameObject);
					currentWaypoint++;
					timer=10;
				}
				if (currentWaypoint>=Waypoints.Length)
				{
					currentWaypoint=Waypoints.Length;
				} else{
					navMesh.destination=Waypoints[currentWaypoint].transform.position;
				}
			}
		}
	}
}
