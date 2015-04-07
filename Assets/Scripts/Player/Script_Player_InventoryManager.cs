using UnityEngine;
using System.Collections;

public class Script_Player_InventoryManager : MonoBehaviour {

	public Script_Weapon_Base[] weaponSlots;
	public Script_InventoryItem[] secondarySlots;
	public Script_InventoryItem[] backPack;
	public WeaponType[] weaponTypes;

	public int selectedPrimary = 0;
	public int selectedSecondary = 0;

	public bool doLog = true;


	void Update(){
		if(doLog){
			Debug.Log (selectedPrimary + "/" + selectedSecondary+"/"+weaponSlots.Length);
		}
	}

	public void PickUp(Script_InventoryItem item){

	}

	public void SetBackPackSize(){

	}

	public void SetGunSlotsSize(){

	}
}
