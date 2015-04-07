using UnityEngine;
using System.Collections;

public class WeaponType : MonoBehaviour {

	public string type;
	public string userFriendlyType;
	public float defaultAmmoStash;
	public float currentAmmoStash;
	public float currentMaxAmmoStash;

	// Use this for initialization
	void Start () {
		currentAmmoStash = defaultAmmoStash;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
