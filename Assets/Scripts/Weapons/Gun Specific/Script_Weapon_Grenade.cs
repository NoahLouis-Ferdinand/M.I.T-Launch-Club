using UnityEngine;
using System.Collections;

public class Script_Weapon_Grenade : Script_Weapon_Base {

	public GameObject grenadePrefab;
	public float throwImpulse = 1000;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void FireOnce(Quaternion rotation){
		GameObject instantiatedObject = (GameObject) Instantiate (grenadePrefab,transform.position+(transform.rotation*offset),transform.rotation);
		instantiatedObject.GetComponent<Rigidbody>().AddForce (transform.rotation*(new Vector3(throwImpulse,0,0)));
	}

	public override Transform GetFireTransform(){
		return transform;
	}
}
