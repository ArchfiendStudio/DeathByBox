using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class circleLoad : MonoBehaviour {

public Image filler;

public Text text;

public Text combo;

bool oun;

public float t = 0,died,theVal;



public float timer,timer2;
public float maxSec,startTime,endtime;

public healthbar script;

float sec;
 float p = 0;

void Start()
{
	sec = maxSec;
	//StartCoroutine(second());
}

public void starter()
{
	maxSec = 3f;
	StartCoroutine(second());
}


void Update()
{
	
	

	if(script.num == 4)
	{
		
		p = timer;
		text.text = "your Score:"+p;
	}
	else
	{

		timer += Time.deltaTime;
		timer2 += Time.deltaTime;
	//	Debug.Log(timer2);
		text.text = "timer :"+timer;
	}

	

}

IEnumerator second()
{
	yield return new WaitForSeconds(1f);

	
	if(maxSec>0)
	{
		maxSec--;
		t++;
	}
	else
	{
		StopCoroutine(second());
	}

	fillLoading();
	StartCoroutine(second());
	
}

void fillLoading()
{
	float fill = maxSec/sec;

	filler.fillAmount = fill;

	
}

public void changer(float count)
{
	
	
	
	if(count ==1 && 5f - timer <3f)
	{
		died++;
		combo.text = "COMBO"+ died;
		timer = 0;
		if(died ==1)
			endtime = timer2;
		if(died == 3)
			startTime = timer2;
		if(died ==4)
			died =0;
	}
	theVal = endtime - startTime;
	//if(died ==3 && )

}

}
