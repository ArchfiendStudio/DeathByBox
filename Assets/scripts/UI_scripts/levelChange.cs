using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelChange : MonoBehaviour {

	// Use this for initialization

	public void changeToScene(string sceneTochange)
	{
		SceneManager.LoadScene(sceneTochange);
	}


}
