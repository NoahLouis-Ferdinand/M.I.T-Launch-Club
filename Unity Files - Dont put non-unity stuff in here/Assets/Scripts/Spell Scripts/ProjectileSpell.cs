using UnityEngine;
using System.Collections;

public class ProjectileSpell : _BaseSpell {

	public GameObject castEffect;
	public GameObject projectile;

	public override void Cast(float magnitude, Vector3 position, Quaternion rotation){
		Instantiate (projectile,position,rotation);
		if (castEffect != null) {
			Instantiate (castEffect,position,rotation);
		}

	} 

	void Start(){
		this.castType = Caster.PROJECTILE;
	}

}
