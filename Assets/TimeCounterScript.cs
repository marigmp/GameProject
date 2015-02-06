using UnityEngine;
using System.Collections;

public class TimeCounterScript : MonoBehaviour {

	private float totalTime;

	private int hour;
	private int minutes;
	private int seconds;

	// Use this for initialization
	void Start () {
		totalTime = 0;
		//Instantiate(GameObject.Find("TimeCounter"), new Vector3(0f,0f,10f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		totalTime += Time.deltaTime;
		hour = Mathf.FloorToInt (totalTime / 3600);
		minutes = Mathf.FloorToInt ((totalTime - 3600 * hour) / 60);
		seconds = Mathf.FloorToInt (totalTime-hour * 3600 - minutes * 60);

		Debug.Log ("Time = " + hour  +":" + minutes + ":" + seconds);
		//GUI.Label (new Rect(0, 0, 100, 50), "Time = " + hour  +":" + minutes + ":" + seconds);
	}
}
