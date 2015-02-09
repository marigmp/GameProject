using UnityEngine;
using System.Collections;

public class HelpButton : MonoBehaviour {

	Vector3 mouse_position;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update()
	{
		Vector3 moveToward = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		mouse_position = moveToward;
		
		if ((mouse_position.x > transform.position.x - 1) && (mouse_position.x < transform.position.x + 1)) 
		{
			if((mouse_position.y > transform.position.y-5) && (mouse_position.y < transform.position.y+5)) 
			{
				if(Input.GetButtonDown ("Fire1"))
				{
					Invoke ("LoadLevel", 1f);
				}
			}
		}		
	}

	void LoadLevel() {
		Application.LoadLevel ("help_scene");
	}
}
