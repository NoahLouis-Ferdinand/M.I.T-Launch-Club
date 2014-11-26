using UnityEngine;
using System.Collections;

public class TimedLife : MonoBehaviour {

	// Use this for initialization
	public float lifeSpan;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		lifeSpan -= Time.deltaTime;
		if(lifeSpan<=0){
				Destroy(gameObject);
		}
	}
}
