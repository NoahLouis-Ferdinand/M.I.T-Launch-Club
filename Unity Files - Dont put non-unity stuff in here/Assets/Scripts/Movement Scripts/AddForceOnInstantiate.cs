using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class AddForceOnInstantiate: MonoBehaviour {
	
	// Use this for initialization
	private Rigidbody body;
	public float force;
	
	void Start () {
		body = GetComponent<Rigidbody> ();
		//body.useGravity = false;
		body.AddForce (transform.forward * force);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
}
