using UnityEngine;
using System.Collections;

[RequireComponent(Rigidbody)]

public class BouncingRigidbody : MonoBehaviour {

	// Use this for initialization
	public float bounceEfficiency = 0.75;
	private Rigidbody body;

	void Start () {
		body = GetComponent<Rigidbody> ();
	}

	void OnCollisionEnter(Collision collision){
	
	}

}
