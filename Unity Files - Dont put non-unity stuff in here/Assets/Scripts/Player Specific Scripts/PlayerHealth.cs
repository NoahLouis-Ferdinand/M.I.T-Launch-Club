using UnityEngine;
using System.Collections;

[RequireComponent(typeof(IDestroyable))]

public class PlayerHealth : MonoBehaviour, IDamageable {

	public float maxHealth = 100;
	public float healthRegenPerSecond = 5;
	public float regenDelay = 3;
	public float armourPercentage;

	private float damageTimer;
	private float currentHealth;

	private IDestroyable destroy;

	// Use this for initialization
	void Start () {
		armourPercentage = Mathf.Clamp (armourPercentage, 0, 1);
		currentHealth = maxHealth;
		destroy = (IDestroyable)GetComponent (typeof(IDestroyable));
	}
	
	// Update is called once per frame
	void Update () {
		if (damageTimer <= 0) {
			currentHealth += healthRegenPerSecond * Time.deltaTime;
		} else {
			damageTimer -= Time.deltaTime;
		}
				
	}

	public void ApplyDamage(float damage){
		damageTimer = regenDelay;
		currentHealth -= damage * (1 - armourPercentage);
		if (currentHealth <= 0) {
			destroy.Destroy();
		}
	}
}
