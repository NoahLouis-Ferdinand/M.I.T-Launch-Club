using UnityEngine;
using System.Collections;

public class WeaponStats : MonoBehaviour {

	public float damage;
	public float fireRate;
	public float accuracy;
	public string fireMode;

	public float magazineSize;
	public float ammoStashSizeBase;
	public float ammoPerShot;
	public float projectilesPerShot;
	public bool usesAmmo = true;


	public Texture crossHair;
	public Texture weaponIcon;
	public Texture ammoIcon;

	public static string semiAuto = "SEMI";
	public static string fullAuto = "FULL";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public float GetBulletDelay(){
		return 1 / fireRate;
	}
	
}
