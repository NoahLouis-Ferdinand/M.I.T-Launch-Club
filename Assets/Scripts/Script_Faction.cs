using UnityEngine;
using System.Collections;

public class Script_Faction : MonoBehaviour {


	public string userFriendlyName;
	public Texture factionIcon;
	public string id;
	ArrayList alliedFactions = new ArrayList();

	public static string allHostile = "HOSTILE";
	public static string allPassive = "PASSIVE";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool isAgressiveTo(string factionId){
		return !(factionId == Script_Faction.allPassive || factionId == id || alliedFactions.Contains (factionId));
	}
}
