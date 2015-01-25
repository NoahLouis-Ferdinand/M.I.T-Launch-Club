using UnityEngine;
using System.Collections;

public class BounceDeform : MonoBehaviour {

	// Use this for initialization
	public float impactForceDeformModifier = 0.7f;
	public float impactForceDeformCap = 0.8f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision){
		Vector3 velocity = collision.relativeVelocity*impactForceDeformModifier;
		//velocity = Mathf.Clamp (velocity, 0, impactForceDeformCap);
		gameObject.transform.localScale = velocity;
	}

	void OnCollisionExit(Collision collision){
		transform.localScale = Vector3.one;
	}
	
	
}
