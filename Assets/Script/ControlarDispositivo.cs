using UnityEngine;
using System.Collections;

public class ControlarDispositivo : MonoBehaviour {

	public AudioClip dispositivo;
	public AudioClip nada;

	private float condicao;

	private bool entrada0;
	private bool entrada1;

	private Vector3 pos_mouse;
	private Vector3 pos_corrente;
	private Vector3 posicaoinicial;

	private int countWin = 0;

	// Use this for initialization
	void Start () 
	{
		audio.clip = nada;
		pos_mouse = Vector3.right;
		condicao = 0;
	}

	void OnTriggerEnter2D( Collider2D other )
	{
		Debug.Log ("Hey");

		if(other.CompareTag("bact"))
		{
			//Invoke ("destroyBact", 3f);			
			DestroyObject(other.gameObject);
			//Debug.Log("colisao bacterias");
			countWin++;

			if(countWin >= 5)
				Application.LoadLevel("winScene");
		}
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
			entrada0 = Input.GetButtonDown ("Fire1");
			if (entrada0) 
			{
				audio.clip = dispositivo;
				audio.Play();
			}
			pos_corrente = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			pos_corrente.z = 0;
			transform.position = pos_corrente;
			entrada1 = Input.GetButtonUp("Fire1");
			if (entrada1) 
			{

				transform.position = posicaoinicial;
				condicao = 0;
				audio.clip = nada;

			}
		}
	}
}
