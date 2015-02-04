using UnityEngine;
using System.Collections;

public class PosicionarCameraZoom : MonoBehaviour {

	private Vector3 pos_mouse;
	private Vector3 pos_inicial_camera;

	// Use this for initialization
	void Start () 
	{
		pos_mouse = Vector3.right;
		pos_inicial_camera = transform.position;		
	} 	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.C)) 
		{
			Vector3 moveToward1 = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			pos_mouse = moveToward1;
			transform.position = pos_mouse;
		}

		if (Input.GetButtonUp("Fire1")) 
		{
			transform.position = pos_inicial_camera;
		}
	}
}
