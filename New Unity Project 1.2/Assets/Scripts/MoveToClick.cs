using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveToClick : MonoBehaviour {
	
	GameObject player;
    RaycastHit hit;
	Vector3 playerPos;
	float speed;
    
    // Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
		Vector3 playerPos = new Vector3(0,10,0);
		//speed = 100.0f;
        hit = new RaycastHit(); 
		speed = speed * Time.deltaTime;
	
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            if (Input.GetMouseButtonDown(0)) {
				movePlayer();
            }
        }
	}
	
	void movePlayer(){
		
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);				
		
		if (Physics.Raycast(ray, out hit)) {
				print("HEY");
				transform.position = Vector3.Slerp(player.transform.position, hit.point, speed);
				//Vector3 newPos = new Vector3(hit.point.x - transform.position.x, hit.point.y - transform.position.y, hit.point.z - transform.position.z);
				//player.transform.position = newPos;			
           }
	
	
	}

	
}











/*
 using System;
public static Vector3 MoveTowards (Vector3 current, Vector3 target, float maxDistanceDelta)
{
	Vector3 a = target - current;
	float magnitude = a.magnitude;
	if (magnitude <= maxDistanceDelta || magnitude == 0f)
	{
		return target;
	}
	return current + a / magnitude * maxDistanceDelta;
}
*/














/*
 * 	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            if (Input.GetMouseButtonDown(0)) {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit, 1000.0f)) {

					Vector3 newpos = new Vector3(hit.point.x, 0.5f, hit.point.z);
                    player.transform.position = newpos;
                }
            }
        }
	}
	
	
	*/