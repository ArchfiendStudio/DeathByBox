using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class healthbar : MonoBehaviour {


	public Image[] img;

	
	public Text over;
	public GameObject stopSpwn;
	public GameObject stopEnem;

	public GameObject respawning;

	public float time;
	
	public int num = 0;

	// Use this for initialization
	
	void Start()
	{
		over.enabled = false;
		respawning.SetActive(false);
	}

	void Update()
	{
		
		if(num == 4)
		{
			
			over.enabled = true;
			stopSpwn.SetActive(false);
			stopEnem.SetActive(false);
			respawning.SetActive(true);
		}
		
	}
	public void healthKill(bool count)
	{
		
	
		
		if(count == true)
		{
		
		 Destroy(img[num]);
		}
		else
		{
			return;
		}
		num++;
		

	}



}
