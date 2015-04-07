using UnityEngine;
using System.Collections;

public class Script_Weapon_Gun_Shotgun: Script_Weapon_Gun_Base{

	//all shotguns should inherit from this class
	Quaternion actualAngle;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void FireOnce(Quaternion fireAngle){
		doFireEffects ();
		for(float iteration = 0; iteration <= stats.projectilesPerShot; iteration++){
			Debug.Log ("Shoot");
			actualAngle = fireAngle;
			actualAngle.y = fireAngle.y + Random.Range(-stats.accuracy, stats.accuracy);
			actualAngle.z = fireAngle.z + Random.Range(-stats.accuracy, stats.accuracy);
			//Instantiate (pelletPrefab, firePos.position, actualAngle);			

		}
	}
}
