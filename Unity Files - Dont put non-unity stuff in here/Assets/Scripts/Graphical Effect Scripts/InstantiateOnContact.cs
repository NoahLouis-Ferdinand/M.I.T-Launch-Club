using UnityEngine;
using System.Collections;

public class InstantiateOnContact : MonoBehaviour {

	public GameObject objectToInstantiate;
	public bool scaleByImpactForce;
	public bool onlyStaticObjects = true;

	public float scaleMultiplier = 1;
	public float maxScale = 5;
	public float minVelocity = 3f;

	void OnCollisionEnter (Collision c) {
		if(c.relativeVelocity.magnitude > minVelocity && c.gameObject.isStatic){
			ContactPoint contact = c.contacts [0];
			var hitRotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
			GameObject g = (GameObject) Instantiate(objectToInstantiate, contact.point, hitRotation);
			if(scaleByImpactForce){
				float deform = (Mathf.Pow(c.relativeVelocity.magnitude,1.5f))*scaleMultiplier;
				deform = Mathf.Clamp (deform,0.1f,maxScale);
				g.transform.localScale = new Vector3(deform, g.transform.localScale.y, deform);
			}
		}
	}
}
