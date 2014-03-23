using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	//public GameObject attackObject;
	public string WayPointTagName = "Enemy";
	public GameObject conWP;
	public NavMeshAgent navMesh;
	//comms
	// Use this for initialization
	void Start () {
		navMesh = GetComponent<NavMeshAgent>();
	
	}
	
	// Update is called once per frame
	void Update () {

		StartCoroutine (attackEnemies ());
	}


	public IEnumerator attackEnemies(){
		
		//Collider[] colliders=Physics.OverlapSphere(transform.position,2.0f);
		Collider[] colliders = Physics.OverlapSphere (transform.position, 3.0f);
		
		foreach (Collider c in colliders) {
			if (c.gameObject.tag == WayPointTagName)
			{
				//transform.position += new Vector3(10.0f, 10.0f, 10.0f);
				navMesh.destination = c.gameObject.transform.position;
				yield return new WaitForSeconds(0.01f);
				navMesh.destination = conWP.transform.position;
				
			}
		}
	}

}
