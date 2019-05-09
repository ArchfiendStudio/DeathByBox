using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demGro : MonoBehaviour {


	public bool isFlat = true;
	private Rigidbody rigid;
	// Use this for initialization
	void Start () {

		rigid  = GetComponent<Rigidbody>();
	//	camParent = new GameObject("CamParent");
	//	camParent.transform.position = this.transform.position;
	//	this.transform.parent = camParent.transform;
	//	Input.gyro.enabled = true;

		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 tilt = Input.acceleration;
		if(isFlat)
		{
			tilt = Quaternion.Euler(90,0,0) * tilt;


		}
		rigid.AddForce(tilt); 
		Debug.DrawRay(transform.position + Vector3.left,tilt,Color.cyan);
	//	camParent.transform.Rotate(0,-Input.gyro.rotationRateUnbiased.y,0);
	//	this.transform.Rotate(-Input.gyro.rotationRateUnbiased.x,0 ,0);
		
	}
}
