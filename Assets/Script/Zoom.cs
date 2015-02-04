using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour {
	
	public Camera camara;

	private float zoom_inicial;

	private float condicao;
	private float cond0;

	private bool entrada0;
	private bool entrada1;

	private Vector3 pos_mouse;
	private Vector3 pos_corrente;
	private Vector3 posicaoinicial;


	// Use this for initialization
	void Start () 
	{
		pos_mouse = Vector3.right;
		condicao = 0;
		zoom_inicial = camara.orthographicSize;
	}

	// Update is called once per frame
	void Update () 
	{
		Vector3 moveToward1 = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		pos_mouse = moveToward1;
		if ((pos_mouse.x > transform.position.x-0.1) && (pos_mouse.x < transform.position.x+0.1)) 
		{
			if ((pos_mouse.y > transform.position.y-0.1) && (pos_mouse.y < transform.position.y+0.1)) 
			{
				entrada0 = Input.GetButtonDown ("Fire1");
				if (entrada0) 
				{
					
					Vector3 moveToward = Camera.main.ScreenToWorldPoint (Input.mousePosition);
					pos_mouse = moveToward;
					pos_mouse.z = 0; 
					transform.position = pos_mouse;
					posicaoinicial = pos_mouse;
					condicao = 1;
					
				}
			}
		}

		if (condicao == 1) 
		{
			if (cond0 == 0)
			{
				pos_corrente = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				pos_corrente.z= 0;
				transform.position = pos_corrente;
			}
			if (Input.GetKeyDown (KeyCode.C)) 
			{
				camara.orthographicSize--;
				pos_corrente = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				transform.position = pos_corrente;
				cond0 = 1;
			}
			entrada1 = Input.GetButtonUp("Fire1");
			if (entrada1) 
			{
				camara.orthographicSize = zoom_inicial;
				transform.position = posicaoinicial;
				condicao = 0;
				cond0 = 0;
			}
		}
	}
}