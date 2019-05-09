using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shootScript : MonoBehaviour {


	public LayerMask layer;
	public int damageDone = 1;
	public float range = 100f;

	public float dem = 0;

	public clockTime newTime;


	public circleLoad clock;

	public float timer =0;
	
//	GameObject timeScript;
	
	
	private float nextFire,currTime;
	public float fireRate =.25f,time1;

	public Camera cam;

	void Start()
	{

		

//	clock.enabled = false;
	clock.gameObject.SetActive(false);
	//combo.gameObject.SetActive(false);
		
	}

	// Use this for initialization
	
	// Update is called once per frame

	void Update () {

		
		
		if(Input.GetButton("Fire1") && Time.time >nextFire)
		{
			//Debug.Log("hit");
			nextFire = Time.time + fireRate;
		//	timeScript.SetActive(true);
			
			
			
			StartCoroutine(shooting());
		}

			

	}

	IEnumerator shooting()
	{
		
		
		
		
		RaycastHit hit;

		if(Physics.Raycast(cam.transform.position,cam.transform.forward,out hit,range,layer))
		{
			//Debug.Log(hit.transform.name);

			
			

			
			
		//	Debug.DrawRay(cam.transform.position,cam.transform.forward,Color.green,2f);
			
			enemyHealth health = hit.collider.GetComponent<enemyHealth>();
			collisionD destruction = hit.collider.GetComponent<collisionD>();
			

			if(health != null)
			{
						
					clock.enabled = true;
					clock.gameObject.SetActive(true);
					clock.starter();
					
					
					
				
	
			
				yield return new WaitForSeconds(1f);

			
					health.damageHit(damageDone);

			}
			
			
	 		time1 =	clock.timer;
			clock.changer(1);
			clock.enabled = false;
			clock.gameObject.SetActive(false);
					
		

			if(destruction != null)
			{
				destruction.killiingItem(true);
			}

		
			
		}


		
	}



}
