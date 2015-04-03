using UnityEngine;
using System.Collections;

public class Script_Weapon_Gun_Shotgun_Base: Script_Weapon_Gun_Base, IFireable{

	//all shotguns should inherit from this class

	public float pelletCount = 10;
	//public float pelletSpeed = 5;
	public GameObject pelletPrefab;

	Quaternion fireAngle;
	Quaternion actualAngle;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Fire(Quaternion fireAngle){

		if (isEnabled && Cooldown ()) {
			fireSoundSource.PlayOneShot(fireSound);
			for(float iteration = 0; iteration <= pelletCount; iteration++){
				actualAngle = fireAngle;
				actualAngle.y = fireAngle.y + Random.Range(-accuracy, accuracy);
				actualAngle.z = fireAngle.z + Random.Range(-accuracy, accuracy);
				Instantiate (pelletPrefab, firePos.position, actualAngle);
			}
		}
	}
}
