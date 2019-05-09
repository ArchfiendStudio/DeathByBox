using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeekGame.Input;



public class CamMove : MonoBehaviour {

	Vector2 mouseLook;
	Vector2 smoothV;
	public float sensitivity = 5.0f;
	public float smoothing = 2.0f;
	GameObject charecter;
	public float rotx,roty;
	public float xrot,yrot;
	

	// Use this for initialization
	void Start () {

		xrot = transform.rotation.x;
		Cursor.visible = true;
		charecter = this.transform.parent.gameObject;
		
	}
	
	// Update is called once per frame
	void Update () {

		
		rotx = JoystickRotate.instance.H;
		roty = JoystickRotate.instance.V;



	//	var md = new Vector2(Input.GetAxisRaw("Mouse X"),Input.GetAxisRaw("Mouse Y"));

		var md = new Vector2(rotx,roty);
		md = Vector2.Scale(md,new Vector2(sensitivity *smoothing,sensitivity*smoothing));
		
		if(transform.eulerAngles.x >300f)
			xrot =-1*(360 - transform.eulerAngles.x);
		else
			xrot =-1*( 0 - transform.eulerAngles.x);
	
		xrot = Mathf.Clamp(xrot,-10f,10f);


	

		md.y = Mathf.Clamp(md.y,-80f,80f);
		md.x = Mathf.Clamp(md.x,-60f,60f);
		smoothV.x = Mathf.Lerp(smoothV.x,md.x, 1f / smoothing);
		smoothV.y = Mathf.Lerp(smoothV.y,md.y,1f / smoothing);

		
		
		mouseLook += smoothV;

		transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
		charecter.transform.localRotation = Quaternion.AngleAxis(mouseLook.x,charecter.transform.up);

		
	}

	public void newSense(float sensy)
	{
		sensitivity = sensy;
	}
}
