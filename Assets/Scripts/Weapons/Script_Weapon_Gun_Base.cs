using UnityEngine;
using System.Collections;

public class Script_Weapon_Gun_Base : Script_Weapon_Base{

	//all guns should inherit from this class

	public AudioSource fireSoundSource;
	public AudioClip fireSound;
	public ParticleSystem particle;

	public Transform firePos;

	public override Transform GetFireTransform(){
		return firePos;
	}

	public void doFireEffects(){
		particle.Play();
		fireSoundSource.PlayOneShot(fireSound);
	}



}
