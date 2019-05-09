using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawns : MonoBehaviour {


	public GameObject[] enemies;
	public Vector3 spawnValues;
	public float spawnWait;
	public float spawnMostWait;
	public float spawnLeastWait;
	public int startWait;
	public bool on;
	public float timer;
	int randEnemy;
	void Start () {

		StartCoroutine(waitSpawner());
	}
	
	// Update is called once per frame
	void Update () {
		
		timer += Time.time;
		spawnWait = Random.Range(spawnLeastWait,spawnMostWait);
	}

	IEnumerator waitSpawner()
	{
		yield return new WaitForSeconds (startWait);

		while(on)
		{
			randEnemy = Random.Range(0,1);
			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x,spawnValues.x),1,Random.Range(-spawnValues.z,spawnValues.z));
			Instantiate(enemies[randEnemy],spawnPosition + transform.TransformPoint(0,0,0),gameObject.transform.rotation);
			

			yield return new WaitForSeconds(spawnWait);
			
		


		}

	}

}
