using UnityEngine;
using System.Collections;

public class Caster : MonoBehaviour {

	// Use this for initialization
	private ICastable spell;
	public Vector3 offset;

	void Start () {
		spell = (ICastable) gameObject.GetComponent(typeof(ICastable));
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			spell.Cast(1, transform.position, offset, transform.rotation);
		}
	}
}
