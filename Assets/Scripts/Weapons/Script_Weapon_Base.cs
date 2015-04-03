using UnityEngine;
using System.Collections;

public class Script_Weapon_Base : MonoBehaviour {

	//All weapons should inherit from this class

	public string userFriendlyName = "UNASSIGNED";
	public float fireCooldown;
	public bool isEnabled = true;
	public Texture crossHair;
	public Texture weaponIcon;
	public Texture ammoIcon;

	float nextFire;

	void Start() {
		nextFire = Time.time;
	}

	public void DoCooldown(){
		nextFire = Time.time + fireCooldown;
	}

	public bool Cooldown(){
		//will return true if the weapon can be used (cooldown)
		return (Time.time >= nextFire);

	}
	
}
