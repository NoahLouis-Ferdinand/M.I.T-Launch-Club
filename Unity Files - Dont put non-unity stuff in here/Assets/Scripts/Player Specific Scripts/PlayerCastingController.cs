using UnityEngine;
using System.Collections;

public class PlayerCastingController : MonoBehaviour {

	private Caster c;
	public int selection;
	public float cooldown = 0.5f;
	private float nextFireTime = 0;
	// Use this for initialization
	void Start () {
		c = GetComponentInChildren<Caster> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1")&&Time.time > nextFireTime) {
			c.Cast(selection);
			nextFireTime = Time.time +cooldown;
		}
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			selection = 0;
			Debug.Log (selection);
		}else{
			if(Input.GetKeyDown (KeyCode.Alpha2)){
				selection = 1;
				Debug.Log (selection);
			}
		}
	}
}
