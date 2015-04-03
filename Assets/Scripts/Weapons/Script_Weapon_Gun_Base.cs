using UnityEngine;
using System.Collections;

public class Script_Weapon_Gun_Base : Script_Weapon_Base{

	//all guns should inherit from this class
	public AudioSource fireSoundSource;
	public AudioClip fireSound;
	public string firePosObjectName;
	public Transform firePos;

	//lesser values are more accurate
	public float accuracy = 0;

	void Start() {
		fireSoundSource = GetComponentInChildren<AudioSource> ();
		firePos = transform.FindChild ("firePos").transform;
	}



}
