using UnityEngine;
using System.Collections;

public class elephant_Movement : MonoBehaviour {

	// Use this for initialization
	public GameObject ele;
	public NavMeshAgent navMesh;
	// Use this for initialization
	void Start () {
		navMesh=GetComponent<NavMeshAgent>();
		navMesh.destination=ele.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		navMesh.destination=ele.transform.position;
		
	}
}
