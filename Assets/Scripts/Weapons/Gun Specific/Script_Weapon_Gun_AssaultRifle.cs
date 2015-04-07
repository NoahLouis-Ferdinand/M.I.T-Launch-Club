using UnityEngine;
using System.Collections;

public class Script_Weapon_Gun_AssaultRifle :Script_Weapon_Gun_Base {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void FireOnce(Quaternion fireAngle){
		doFireEffects ();
	}
}
