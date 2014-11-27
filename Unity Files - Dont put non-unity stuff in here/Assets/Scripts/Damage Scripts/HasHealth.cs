using UnityEngine;
using System.Collections;

[RequireComponent (typeof (IKillable))]

public class HasHealth : MonoBehaviour {

	// Use this for initialization
	public float maxHealth = 100;
	public float regenDelay = 5;
	public float regenRate = 5;
	private float currentHealth;
	private float damageTimer;
	private IKillable deathHandler;

	void Start () {	
			currentHealth = maxHealth;
			deathHandler = (IKillable) gameObject.GetComponent(typeof(IKillable));
	}

	// Update is called once per frame
	void Update () {

		if (damageTimer > 0) {
			damageTimer -= Time.deltaTime;
		}else{
			currentHealth += regenRate*Time.deltaTime;
		}
	}

	public void ApplyDamage(float damage){
		damageTimer = regenDelay;
		currentHealth -= damage;
		if (currentHealth <= 0) {
			deathHandler.Die();
		}
	}
}
