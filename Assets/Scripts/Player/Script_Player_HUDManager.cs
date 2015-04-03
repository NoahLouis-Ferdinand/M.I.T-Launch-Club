using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Script_Player_HUDManager : MonoBehaviour {

	public RawImage[] slots;
	public RawImage ammoIcon;
	public Text ammoText;
	public Text healthText;
	float ammoClip = 0f;
	float ammoStash = 0f;
	
	void Start(){
		slots = new RawImage[4];
	}
	public void SetAmmoClip(float ammo){
		ammoClip = ammo;
		ammoText.text = (ammoClip + "/" + ammoStash);
	}

	public void SetAmmoStash(float ammo){
		ammoStash = ammo;
		ammoText.text = (ammoClip + "/" + ammoStash);
	}

	public void SetHealth(float health){
		healthText.text = health.ToString ();
	}

	public void shuffleWeaponSlots(int amount){
		Texture[] temp = new Texture[4];
		int index;

		for(int i = 0;i<slots.Length;i++) {
			index = i+amount;
			if (amount > slots.Length) {
				amount = 0;
			} else {
				if (amount < 0) {
					amount = slots.Length;
				}
			}
			temp[i] = slots[index].texture;
		}
		for(int i = 0;i<slots.Length;i++) {
			slots[i].texture = temp[i];
		}
		temp = null;
	}

}
