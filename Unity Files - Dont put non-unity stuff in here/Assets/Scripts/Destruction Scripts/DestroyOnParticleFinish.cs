using UnityEngine;
using System.Collections;

public class DestroyOnParticleFinish : MonoBehaviour {

	private IDestroyable destroy;
	private ParticleSystem particle;
	private float lifeSpan;
	public float durationMultiplier = 1;
	
	void Start () {
		destroy = (IDestroyable) GetComponent (typeof(IDestroyable));
		particle = (ParticleSystem)GetComponentInChildren<ParticleSystem> ();
		lifeSpan = particle.duration*durationMultiplier;
	}
	
	// Update is called once per frame
	void Update () {
		lifeSpan -= Time.deltaTime;
		if(lifeSpan<=0){
			destroy.Destroy();
		}
	}
}
