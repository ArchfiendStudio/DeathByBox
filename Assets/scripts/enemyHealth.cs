using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHealth : MonoBehaviour {

	
	public int currentHealth = 1;



	public circleLoad timing;

	public clockTime scoring;

	public float count = 0,Lt,Ct,Bt;
	public float timer,b;

	void Start()
	{
		
		
	}
	void Update()
	{
		timer += Time.deltaTime;
	

	
	}

	public void damageHit(int damageDone)
	{
		currentHealth -= damageDone;
		if(currentHealth==0)
		{
			
		//	Lt = Ct;
			b = Time.realtimeSinceStartup;
		
			Ct = b;
			if(Ct- Lt <4f)
				Bt =1;

			
		//	Debug.Log("Ct-Lt :"+(Ct - Lt));

				


			scoring.currentTime = b;
			
		//	Debug.Log("Ct"+Ct+"lt"+Lt);

		

		//	Debug.Log("b:"+b);
			scoring.a ++;
			scoring.t += 5;




			gameObject.SetActive(false);
		
		
			
		}
	}





}
