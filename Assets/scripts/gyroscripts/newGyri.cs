using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newGyri : MonoBehaviour {

	// Use this for initialization
	#region Instance
		private static newGyri instance;
	/* 	public static newGyri Instance 
		{
			get 
			{

				if(instance == null)
				{
					instance = FindObjectOfType<newGyri>();
					if(instance == null)
					{
						instance = new GameObject("Spawned GyroManager",typeof(newGyri)).GetComponent<newGyri>();
					}

				}
			}
			set
			{
				instance = value;
			}
		} */
	#endregion

	[Header("Logic")]

	private Gyroscope gyro;
	private Quaternion rotation;
	private bool gyroActive;

	public void EnableGyro()
	{
		if(gyroActive)
			return;
		if(SystemInfo.supportsGyroscope)
		{
			gyro = Input.gyro;
			gyro.enabled  = true;
			gyroActive = gyro.enabled;
			
		}
		
	}

	private void Update()
	{
		if(gyroActive)
		{
			rotation = gyro.attitude;
			Debug.Log(rotation);
		}
	}

	public Quaternion GetGyroRotation()
	{
		return rotation;
	}
	

} 