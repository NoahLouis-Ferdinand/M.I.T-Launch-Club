using UnityEngine;
using System.Collections;

public class Script_Weapon_Base : Script_InventoryItem {

	//All weapons should inherit from this class


	public WeaponStats stats;
	public bool isEnabled = true;
	public float ammoInMag;
	
	public Vector3 instantiateOffset;

	void Start() {
	}

	public virtual Transform GetFireTransform (){
		Debug.LogError ("Oh Noes! Somebody is trying to use GetFireTransform, and it hasnt been overridden! someone go override this!");
		return null;
	}

	public virtual void FireOnce (Quaternion fireAngle){

	}
}
