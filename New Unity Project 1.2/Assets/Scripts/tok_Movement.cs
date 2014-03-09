using UnityEngine;
using System.Collections;

public class tok_Movement : MonoBehaviour {

	//public Transform main_tok;
	GameObject main_tok;
	GameObject wp;
	// Use this for initialization
	void Start () {
		main_tok = GameObject.Find ("Bug");
		wp = GameObject.Find ("wp_Bug4");
	}
	
	// Update is called once per frame
	void Update () {

		if (main_tok.transform.position == wp.transform.position) {
						GetComponent<NavMeshAgent> ().destination = main_tok.transform.position;
				}
	}
}
