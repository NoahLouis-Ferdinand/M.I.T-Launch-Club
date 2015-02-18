using UnityEngine;
using System.Collections;

public class TimedTextureFade : MonoBehaviour {

	public float totalTime;
	public float startTime;
	float fadeSpeed;

	// Use this for initialization
	void Start () {
		fadeSpeed = renderer.material.color.a / startTime;
		Debug.Log (fadeSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		totalTime -= Time.deltaTime;
		if (totalTime >= startTime) {
			Color c = renderer.material.color;
			c.a -= fadeSpeed*Time.deltaTime;
		}
	}
}
