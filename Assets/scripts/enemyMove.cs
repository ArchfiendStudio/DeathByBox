using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour {


	GameObject cam;

	public float speed = 0.25f;
	// Use this for initialization
	void Start () {
		cam = GameObject.FindGameObjectWithTag("Respawn");
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.LookAt(cam.transform);
		transform.position += transform.forward * speed;
		
		
	}
}
