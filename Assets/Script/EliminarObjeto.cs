﻿using UnityEngine;
using System.Collections;

public class EliminarObjeto : MonoBehaviour 
{	
	private Vector3 pos_mouse;

	// Use this for initialization
	void Start () 
	{
		pos_mouse = Vector3.right;

	} 
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 moveToward1 = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		pos_mouse = moveToward1;
		pos_mouse.z = 0; 
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			if ((transform.position.x <= pos_mouse.x+0.1) && (transform.position.x >= pos_mouse.x-0.1)) 
			{	
				if ((transform.position.y <= pos_mouse.y+0.1) && (transform.position.y >= pos_mouse.y-0.1)) 
				{
					gameObject.SetActive (false);
				}
			}
		}
	}
}
