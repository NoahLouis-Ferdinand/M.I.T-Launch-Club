using UnityEngine;
using System.Collections;

public class EffectOnImpact : MonoBehaviour {

	public GameObject effect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision){
		Instantiate (effect, transform.position, Quaternion.identity);
	}
}
