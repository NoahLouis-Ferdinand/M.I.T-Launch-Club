using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Script_DestructionEvent_Explode : MonoBehaviour, IDestroyEvent {

	public float explosionPower;
	public float explosionForceMultiplier;
	public float explosionRadius;
	public float explosionDamage;

	public ParticleSystem[] particles;
	public AudioClip sound;

	AudioSource source;
	Collider[] hits;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnDestroy(){
		source.PlayOneShot (sound);
		foreach (ParticleSystem particle in particles) {
			particle.Play ();
		}
		hits = Physics.OverlapSphere (transform.position, explosionRadius );
		foreach (Collider hit in hits) {
			if(hit.gameObject.tag == "Entity"){
				Debug.Log ("Explosion Hit an Entity!");
			}
			Rigidbody body = hit.gameObject.GetComponent<Rigidbody> ();
			if(body != null){
				body.AddExplosionForce(explosionPower*explosionForceMultiplier,transform.position,explosionRadius);
			}
		}
	}
}
