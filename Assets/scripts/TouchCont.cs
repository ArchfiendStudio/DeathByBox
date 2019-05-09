using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCont : MonoBehaviour {

	// Use this for initialization
	private Touch intitTouch = new Touch();

	public Camera cam;
	public float rotX = 0f;
	public float rotY = 0f;
	private Vector3 origRot;

	public float rotSpeed = 0.5f;
	public float dir = -1;
	void Start () {

		origRot = cam.transform.eulerAngles;
		rotX = origRot.x;
		rotY = origRot.y;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		foreach(Touch touch in Input.touches)
		{
			if(touch.phase == TouchPhase.Began)
			{
				intitTouch = touch;
			}
			else if(touch.phase == TouchPhase.Moved)
			{
				float deltaX = intitTouch.position.x -touch.position.x;
				float deltaY = intitTouch.position.y - touch.position.y;
				rotX -= deltaX * Time.deltaTime * rotSpeed * dir;
				rotY += deltaY * Time.deltaTime * rotSpeed * dir;
				rotX = Mathf.Clamp(rotX,-60f,60f);
				rotY = Mathf.Clamp(rotY,-60f,60f);
				cam.transform.eulerAngles = new Vector3(rotY,rotX,0f);
			}
			else if(touch.phase == TouchPhase.Ended)
			{
				intitTouch = new Touch();
			}
		}
	
		
	}

	
}
