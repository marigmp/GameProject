using UnityEngine;
using System.Collections;

public class BactsCreator : MonoBehaviour {

	public float minSpawnTime = 0.75f; 
	public float maxSpawnTime = 2f;
	public GameObject bactPrefab;
	public int counterBacts = 0;
	public int maxBactsLevel = 7;

	// Use this for initialization
	void Start () {
		Invoke("SpawnBacts",minSpawnTime);
	}
	
	void SpawnBacts()
	{
		//Camera camera = Camera.main;
		GameObject mouth = GameObject.Find ("mouth");
		//var renderer = mouth.GetComponent<Renderer> ();
		/*float width = renderer.bounds.size.x;
		float height = renderer.bounds.size.y;*/

		//Debug.Log ("Width: " + width + ", Height: " + height);

		Vector3 mouthPos = mouth.transform.position;

		float xMax = mouth.transform.position.x + 1f;
		float xRange = 2f;
		float yMax = mouth.transform.position.y + 0.7f;

		//Debug.Log ("Xmax: " + xMax + ", xRange: " + xRange + ", yMax:  " + yMax);

		Vector3 posBact = new Vector3 (mouthPos.x + Random.Range (xMax - xRange, xMax),
		                             Random.Range (-yMax, yMax-0.2f),
		                             bactPrefab.transform.position.z);
		//Debug.Log ("X: " + posBact.x + ", y:  " + posBact.y);
		Instantiate(bactPrefab, posBact, Quaternion.identity);

		if (counterBacts < maxBactsLevel) 
		{
			Invoke ("SpawnBacts", Random.Range (minSpawnTime, maxSpawnTime));
		}

		counterBacts++;
	}
}

/*Camera camera = Camera.main;
Vector3 cameraPos = camera.transform.position;
float xMax = camera.aspect * camera.orthographicSize;
float xRange = camera.aspect * camera.orthographicSize * 1.75f;
float yMax = camera.orthographicSize - 0.5f;*/
