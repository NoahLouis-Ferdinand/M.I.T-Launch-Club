using UnityEngine;
using System.Collections;

public class Script_Weapon_Gun_Pistol : Script_Weapon_Gun_Base {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void FireOnce(Quaternion angle){
		doFireEffects ();
		angle.x += Random.Range(-stats.accuracy,stats.accuracy);
		angle.y += Random.Range(-stats.accuracy,stats.accuracy);
		angle.z += Random.Range(-stats.accuracy,stats.accuracy);
		//Physics.Raycast ();
	}
}
