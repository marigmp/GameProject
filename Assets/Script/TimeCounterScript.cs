using UnityEngine;
using System.Collections;

public class TimeCounterScript : MonoBehaviour {

	private float totalTime;

	private int hour;
	private int minutes;
	private int seconds;

	// Use this for initialization
	void Start () {
		totalTime = 0f;
		//Instantiate(GameObject.Find("TimeCounter"), new Vector3(0f,0f,10f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI()
	{
		totalTime += Time.deltaTime;
		hour = Mathf.FloorToInt (totalTime / 3600);
		minutes = Mathf.FloorToInt ((totalTime - 3600 * hour) / 60);
		seconds = Mathf.FloorToInt (totalTime-hour * 3600 - minutes * 60);

		GUI.Label (new Rect(700, 0, 100, 50), "" + hour  + ":" + minutes + ":" + seconds);
	}
}

/*
 function OnGUI () {
  
    var guiTime = goalTime - Time.time; // You probably want to clamp this value to be between the totalTime and zero
  
    var minutes : int = guiTime / 60;
    var seconds : int = guiTime % 60;
    var fraction : int = (guiTime * 100) % 100;
  
    text = String.Format ("{0:00}:{1:00}:{2:000}", minutes, seconds, fraction); 
    GUI.Label (Rect (400, 25, 100, 30), textTime); //changed variable name to textTime -->text is not a good variable name since it has other use already
  
 }
 */
