using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeekGame.Input;

public class Freecamera : MonoBehaviour {

	public float distance = 10.0f;
	private float currentX = 0.0f;
	private float currentY = 0f;
	private float sensivityX = 3.0f;
	private float sensivityY = 1.0f;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
		currentX += JoystickRotate.instance.H * sensivityX;
		currentY += JoystickRotate.instance.V *sensivityY;

	}

	private void LateUpdate()
	{
		Vector3 dir = new Vector3(0,0,-distance);
		Quaternion rotation = Quaternion.Euler(currentY,currentX,0f);
		transform.position = transform.position + rotation * dir;
		transform.LookAt(transform.position);
	}
}
