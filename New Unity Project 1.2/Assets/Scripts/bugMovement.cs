using UnityEngine;
using System.Collections;

public class bugMovement : MonoBehaviour {
	
	// Use this for initialization
	
	public GameObject wp;
	public GameObject mTok;
	public NavMeshAgent navMesh;
	
	void Start () {
		
		navMesh=GetComponent<NavMeshAgent>();
		//navMesh.destination = wp.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (mTok.activeInHierarchy && wp.gameObject == null) 
		{
			//Debug.Log ("Helelelelel");
			navMesh.destination = mTok.transform.position;
		}


	}
	
}