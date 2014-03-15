using UnityEngine;
using System.Collections;

public class elephant_Movement : MonoBehaviour {

	// Use this for initialization
	GameObject ele_Mother;
	// Use this for initialization
	void Start () {
		ele_Mother = GameObject.Find ("Elephant_Mother");
	}
	
	// Update is called once per frame
	void Update () {
//		GetComponent<NavMeshAgent> ().destination = ele_Mother.transform.position;
		
	}
}
