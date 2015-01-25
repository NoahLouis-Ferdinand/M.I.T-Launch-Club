using UnityEngine;
using System.Collections;

public class ProjectileSpell : _BaseSpell {

	public GameObject castEffect;
	public GameObject projectile;

	public override void Cast(float magnitude, Vector3 position, Vector3 offset, Quaternion rotation){
		Instantiate (projectile,position+(rotation*offset),rotation);
		Instantiate (castEffect,position+(rotation*offset),rotation);
	} 

	void Start(){
		this.castType = Caster.PROJECTILE;
	}

}
