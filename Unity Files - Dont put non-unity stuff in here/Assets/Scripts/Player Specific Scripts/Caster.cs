using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Caster : MonoBehaviour {
	
	private ICastable[] spells;
	public Vector3 offset;
	private Camera view;
	public int selection = 0;

	void Start () {
		view = GetComponentInParent<Camera>();
		spells = (ICastable[]) gameObject.GetComponents (typeof(ICastable));
		foreach(Component i in spells){
			ICastable spell = (ICastable) i;
			Debug.Log(spell.userFriendlyName);
		}

	}

	void Update () {
		if(Input.GetButtonDown("Fire1")){
			if(spells!=null){
				ICastable spell = (ICastable) spells[selection];
				spell.Cast(1, transform.position, offset, view.transform.rotation);
			}else{
				Debug.Log ("Failed attempting to cast spell at selection " + selection.ToString() + " because it was null!");
			}

		}
	}

	public static string BEAM = "beam";
	public static string PROJECTILE = "projectile";
}
