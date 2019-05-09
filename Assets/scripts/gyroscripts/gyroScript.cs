using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gyroScript : MonoBehaviour {

	// Use this for initialization
	private bool gyroEnabled;
	private Gyroscope gyro;

	private GameObject cameraContainer;
	private Quaternion rot;
	public float timer;

	GameObject txt;

	private void Start () {

			cameraContainer = new GameObject("Camera Container");
			cameraContainer.transform.position = transform.position;
			transform.SetParent(cameraContainer.transform);

			txt = GameObject.FindGameObjectWithTag("Finish");
			txt.SetActive(false);

			
		
		


			gyroEnabled = EnableGyro();
	}
	
	// Update is called once per frame

	private bool EnableGyro()
	{

		
	
		if(SystemInfo.supportsGyroscope)
		{
			gyro = Input.gyro;
			gyro.enabled = true;
		

			cameraContainer.transform.rotation = Quaternion.Euler(90f,90f,0f);
			rot = new Quaternion(0,0,1,0);
			return true;
		}
		else
		{
			Debug.Log("gyro not supported");
			return false;
		}
	}

	private void Update () {

		
			

		if(gyroEnabled)
		{
			txt.SetActive(true);
			cameraContainer.transform.localRotation = gyro.attitude *rot;
		}


		
	}
}
