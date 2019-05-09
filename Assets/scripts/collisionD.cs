using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisionD : MonoBehaviour {


	public float timer,counter;

//public circleLoad clocky;
	public GameObject replacement;

	public Image red;

	public enemyHealth enem;
	bool count ;

	public int nos = 0;

	public healthbar heal;
	void Start()
	{
		red.enabled = false;
		
		
	}
	void Update()
	{
		timer += Time.time;
		
	}
	void OnCollisionEnter(Collision col)
	{
	
		
		if(gameObject.name != "enemy" && col.gameObject.name == "cube1")
		{
			

			red.enabled = true;
			count = true;
			Destroy(gameObject);
			heal.healthKill(count);
		
		}

		
	}



	public void killiingItem(bool something)
	{

			if(enem.currentHealth<=0)

				GameObject.Instantiate(replacement,transform.position,transform.rotation);
				
				
	}


}
