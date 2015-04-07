using UnityEngine;
using System.Collections;

public class Script_InventoryItem : MonoBehaviour {

	//All things, including guns, that go in the inventory inherit from this class

	public string userFriendlyName;
	public string description;
	public string redText;
	public float rarity;

	public bool autoPickUp;

	public bool canBeEquippedWeapon = false;
	public bool canBeEquippedSecondary = false;
	public bool isMoney = false;
	public bool isMissionItem = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
