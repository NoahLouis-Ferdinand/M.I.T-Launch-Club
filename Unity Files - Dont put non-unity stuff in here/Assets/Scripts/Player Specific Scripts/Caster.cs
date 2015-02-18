using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Caster : MonoBehaviour {
	
	private Component[] spells;
	private Camera view;
	public bool castingEnabled = true;

	void Start () {
		spells = GetComponents(typeof(ICastable));
	}

	public void Cast(int selection){
		if (castingEnabled) {
			if (spells[selection] != null) {
				ICastable spell = (ICastable)spells[selection];
				spell.Cast (1, this.transform.position, transform.rotation);
				Debug.Log("Cast Successful!");
			} else {
				Debug.Log ("Failed attempting to cast spell at selection " + selection.ToString () + " because it was null!");
			}		
		} 
		else{
			Debug.Log ("Couldnt Cast: Casting is disabled");
		}
	}

	public static string BEAM = "beam";
	public static string PROJECTILE = "projectile";
}
