using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Script_Player_HUDManager : MonoBehaviour {

	Script_Player_InventoryManager inventory;
	Script_Player_WeaponHandler weaponHandler;

	public RawImage weaponSlot;
	public RawImage ammoIcon;
	public RawImage crosshair;
	public Text ammoText;
	public Text healthText;

	public Text crosshairPromptText;
	public RawImage crosshairPromptTexture;
	public float commandPromptDuration;

	public Texture emptyTexture;

	float removePromptTime = 0;
	
	void Start(){
		inventory = GetComponent<Script_Player_InventoryManager> ();
		weaponHandler = GetComponent<Script_Player_WeaponHandler> ();
	}

	void Update(){
		ammoIcon.texture = inventory.weaponSlots[inventory.selectedPrimary].stats.ammoIcon;
		ammoText.text = weaponHandler.selectedGun.ammoInMag + "/" + inventory.weaponTypes[inventory.selectedPrimary].currentAmmoStash;
		weaponSlot.texture = inventory.weaponSlots[inventory.selectedPrimary].stats.weaponIcon;
		crosshair.texture = inventory.weaponSlots [inventory.selectedPrimary].stats.crossHair;
		if(Time.time >=removePromptTime){
			crosshairPromptText.text = "";
			crosshairPromptTexture.texture = emptyTexture;
		}
	}

	public void ShowCommandOption(string prompt,Texture texture){
		crosshairPromptText.text = prompt;
		crosshairPromptTexture.texture = texture;
		removePromptTime = Time.time + commandPromptDuration;

	}

	public void SetCrosshairColor(Color color){
		crosshair.color = color;
	}
}

