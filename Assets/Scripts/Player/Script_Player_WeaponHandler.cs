using UnityEngine;
using System.Collections;

public class Script_Player_WeaponHandler : MonoBehaviour {
	
	public bool canShoot = true;
	public Transform gunPos;
	public Script_Weapon_Base selectedGun;

	Script_Player_InventoryManager inventory;
	float nextFire;

	GameObject currentGunPrefab;


	// Use this for initialization
	void Start () {
		inventory = GetComponent<Script_Player_InventoryManager>();
		nextFire = Time.time;
		currentGunPrefab = (GameObject)Instantiate (inventory.weaponSlots [inventory.selectedPrimary].gameObject, gunPos.position + ( gunPos.rotation*inventory.weaponSlots [inventory.selectedPrimary].instantiateOffset), gunPos.rotation);
		currentGunPrefab.transform.SetParent(transform);
	}
	
	// Update is called once per frame
	void Update () {
		selectedGun = currentGunPrefab.GetComponent<Script_Weapon_Base>();
		float weaponChange = Input.GetAxis ("Mouse ScrollWheel")*10;
		if (weaponChange != 0) {
			inventory.selectedPrimary += (int)weaponChange;
			if (inventory.selectedPrimary > inventory.weaponSlots.Length-1) {
				inventory.selectedPrimary = 0;
			} else {
				if (inventory.selectedPrimary < 0) {
					inventory.selectedPrimary = inventory.weaponSlots.Length-1;
				}
			}
			Destroy (currentGunPrefab);
			currentGunPrefab = (GameObject)Instantiate(inventory.weaponSlots[inventory.selectedPrimary].gameObject,gunPos.position+(gunPos.rotation*inventory.weaponSlots[inventory.selectedPrimary].instantiateOffset),gunPos.rotation);
			currentGunPrefab.transform.SetParent (transform);
		}

		//Check for a fire, and that the character can shoot currently
		if ((selectedGun.stats.fireMode == WeaponStats.semiAuto)&&Input.GetButtonDown ("Fire1")&&(Time.time>nextFire)&&canShoot&&(selectedGun.ammoInMag>=selectedGun.stats.ammoPerShot)) {
			nextFire = Time.time + selectedGun.stats.GetBulletDelay();
			selectedGun.ammoInMag -= selectedGun.stats.ammoPerShot;
			selectedGun.FireOnce(selectedGun.GetFireTransform().rotation);
		}

		if ((selectedGun.stats.fireMode == WeaponStats.fullAuto)&&Input.GetButton("Fire1")&&(Time.time>nextFire)&&canShoot&&(selectedGun.ammoInMag>=selectedGun.stats.ammoPerShot)) {
			nextFire = Time.time + selectedGun.stats.GetBulletDelay();
			selectedGun.ammoInMag -= selectedGun.stats.ammoPerShot;
			selectedGun.FireOnce(selectedGun.GetFireTransform().rotation);
		}

		if(Input.GetButtonDown ("Reload")){
			Reload ();
		}
	}

	public void Reload(){
		if(inventory.weaponTypes[inventory.selectedPrimary].currentAmmoStash>=selectedGun.stats.magazineSize&&selectedGun.ammoInMag != selectedGun.stats.magazineSize){
			selectedGun.ammoInMag = selectedGun.stats.magazineSize;
			inventory.weaponTypes[inventory.selectedPrimary].currentAmmoStash -= selectedGun.stats.magazineSize;
		}
	}
}
