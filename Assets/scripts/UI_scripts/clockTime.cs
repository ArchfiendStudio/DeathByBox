using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clockTime : MonoBehaviour {

	// Use this for initialization

	public float t = 60.0f,combo;

	public enemyHealth enem;
	public enemyMove moving;
	public float lastTime = 0;

	public float centreTime = 0;
	public float currentTime,bufferTime =10f,i;

	
	public Text score,warning,comboMov;

	public float a = 0,x;

	void Start()
	{
		warning.gameObject.SetActive(false);
		comboMov.gameObject.SetActive(false);
	}
	
	void Update()
	{
		
		if(currentTime != centreTime)
			lastTime = centreTime;
	

		
		centreTime = currentTime - 0;
		
		Debug.Log("CT :"+centreTime+"LT :"+lastTime+"Ct-Lt :"+(centreTime- lastTime));
		


		if(centreTime - lastTime < 2f && lastTime !=0)
		{	
			combo =1;
			comboMov.gameObject.SetActive(true);
		}
		else
		{
			combo = 0;
			comboMov.gameObject.SetActive(false);
		}
			
		

		t -= Time.deltaTime;
		if(a ==30)
		{
			warning.gameObject.SetActive(true);
			moving.speed = 2f;
		}
		
		if(a == 35)
		{
			warning.gameObject.SetActive(false);
			moving.speed = 0.30f;
		}

		if(a == 50)
		{
			warning.gameObject.SetActive(true);
			warning.text = "Damn boy , now the boxes are mad and may come in random speed !";
			x = Random.Range(0.25f,0.50f);
			moving.speed = x;
		}

		if(a == 55)
			warning.gameObject.SetActive(false);

		score.text = "kill: "+a+" "+"co :"+combo;
	//	Debug.Log(Time.realtimeSinceStartup);

	}

	

	
}


