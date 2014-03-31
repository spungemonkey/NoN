using UnityEngine;
using System.Collections;

public class NavigationController : MonoBehaviour {

	//Waypoints
	public GameObject[] Waypoints;
	public NavMeshAgent navMesh;
	int currentWaypoint=0;
	public float wait;
	public string WaypointTagName="Waypoint";


	// Use this for initialization
	void Start () {
		navMesh=GetComponent<NavMeshAgent>();
		navMesh.destination=Waypoints[currentWaypoint].transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine(moveWaypoints ());
	}
	
	public IEnumerator moveWaypoints(){
		if (currentWaypoint>=Waypoints.Length)
		{ 
			currentWaypoint=Waypoints.Length;
		} else{
			navMesh.destination=Waypoints[currentWaypoint].transform.position;
		}


		Collider[] colliders=Physics.OverlapSphere(transform.position,2.0f);
		foreach(Collider c in colliders)
		{
			if (c.gameObject.tag==WaypointTagName)
			{
				if (c.gameObject !=null)
				{
					Destroy(c.gameObject);
					yield return new WaitForSeconds(wait);
					
					currentWaypoint++;

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
}
