using UnityEngine;
using System.Collections;

public class Script_Player_WeaponHandler : MonoBehaviour {

	public Script_Weapon_Gun_Base[] weapons;
	public int selected = 0;
	Script_Player_HUDManager hud;

	// Use this for initialization
	void Start () {
		hud = GetComponent<Script_Player_HUDManager>();
	}
	
	// Update is called once per frame
	void Update () {
		float weaponChange = Mathf.Floor(Input.GetAxis ("Mouse ScrollWheel")*10);
		selected += (int) weaponChange;
		hud.shuffleWeaponSlots (selected);
		hud.ammoIcon.texture = weapons [selected].ammoIcon;
	}
}
