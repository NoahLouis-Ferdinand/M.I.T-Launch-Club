using UnityEngine;
using System.Collections;

public class Script_Player_InteractionManager : MonoBehaviour {

	public Camera cam;
	public float pickUpRange =5;
	public float interractRange = 100;

	public Color crossHairColourEnemy;
	public Color crossHairColourFriend;
	public Color crossHairColourNeutral;

	public Texture pickUpItemTexture;

	Script_Player_InventoryManager inventory;
	Script_Player_HUDManager hud;
	Script_Faction playerFaction;

	Ray ray;
	RaycastHit hit;
	GameObject lastObject;

	// Use this for initialization
	void Start () {
		inventory = GetComponent<Script_Player_InventoryManager> ();
		hud = GetComponent<Script_Player_HUDManager>();
		playerFaction = GetComponent<Script_Faction>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Physics.Raycast (cam.transform.position, cam.transform.forward, out hit, interractRange)) {
			switch (hit.collider.gameObject.tag) {
			case "Item":
				Debug.Log ("Item!");
				Script_InventoryItem item = hit.collider.gameObject.GetComponent<Script_InventoryItem> ();
				if (item != null && hit.distance <= pickUpRange) {
					if (item.autoPickUp) {
						inventory.PickUp (item);
					} else {
						hud.ShowCommandOption ("Pick Up (E)", pickUpItemTexture);
						if (Input.GetButtonUp ("Pick Up")) {
							inventory.PickUp (item);
						}
					}
				}
				break;

			case "Entity":
				Debug.Log ("Entity!");
				Script_Faction faction = hit.collider.gameObject.GetComponent<Script_Faction> ();
				if (faction != null) {
					if (faction.isAgressiveTo (playerFaction.id)) {
						hud.SetCrosshairColor (crossHairColourEnemy);
					} else {
						if (faction.id == playerFaction.id) {
							hud.SetCrosshairColor (crossHairColourFriend);
						} else {
							hud.SetCrosshairColor (crossHairColourNeutral);
						}
					}
				}
				break;

			default:
				hud.SetCrosshairColor (crossHairColourNeutral);
				break;

			}	
		} else {
			hud.SetCrosshairColor(crossHairColourNeutral);
		}
	}
}
