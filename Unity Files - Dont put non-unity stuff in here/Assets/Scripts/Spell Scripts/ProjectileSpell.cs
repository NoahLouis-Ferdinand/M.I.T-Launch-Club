using UnityEngine;
using System.Collections;

public class ProjectileSpell : MonoBehaviour, ICastable {

	// Use this for initialization

	public GameObject projectile;
	public float baseManaCost;

	public void Cast(float magnitude, Vector3 position, Vector3 offset, Quaternion rotation){
		Instantiate (projectile,position+(rotation*offset),rotation);
	} 

	public float GetBaseManaCost(){
		return baseManaCost;
	}
}
