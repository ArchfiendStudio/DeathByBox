using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruct : MonoBehaviour {



	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "Plane" && gameObject.name != "destruction")
		{
			Destroy(gameObject);
		}
		
	}
}
