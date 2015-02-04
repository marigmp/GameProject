using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
	
	Vector3 mouse_position;
	public float sizeX_player;

	// Use this for initialization
	void Start () {

	}

	void Update()
	{
		GameObject device = GameObject.FindGameObjectsWithTag ("Device");




		Vector3 moveToward = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		mouse_position = moveToward;

		if ((mouse_position.x > transform.position.x - 1) && (mouse_position.x < transform.position.x + 1)) 
		{
			if((mouse_position.y > transform.position.y-5) && (mouse_position.y < transform.position.y+5)) 
			{
				if(Input.GetButtonDown ("Fire1"))
				{
					Invoke ("LoadLevel", 0f);
				}
			}
		}

	}

	void LoadLevel() {
		Application.LoadLevel ("teste");
	}
}
