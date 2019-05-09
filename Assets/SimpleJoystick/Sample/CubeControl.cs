using UnityEngine;
using System.Collections;
using GeekGame.Input;

public class CubeControl : MonoBehaviour {


	
	public float speed= 0.1f;
	public float rotX,rotY;
	Vector3 origRot;

	Quaternion reY;
	float reYy;
	bool on;
	// Use this for initialization
	void Start () {

		
		reY = gameObject.transform.rotation;
		reYy = reY.y;
		
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate(new Vector3(JoystickMove.instance.H,0f,JoystickMove.instance.V)*speed*Time.deltaTime);
	
		
		rotX = JoystickRotate.instance.H;
		rotY = JoystickRotate.instance.V;

		Debug.Log("x :"+rotX +" y"+rotY);
		
		
		Quaternion rotation = Quaternion.Euler(rotX,0f,0f);
		gameObject.transform.rotation = rotation;

		transform.LookAt(transform.position+new Vector3(JoystickRotate.instance.H,0f,JoystickRotate.instance.V));
		reYy = Mathf.Clamp(reYy,-40f,40f);
		
		if(JoystickFire.instance.Fire){
			Debug.Log("fire");
		}
		
		

		

	
		
	 
	}
	
}
