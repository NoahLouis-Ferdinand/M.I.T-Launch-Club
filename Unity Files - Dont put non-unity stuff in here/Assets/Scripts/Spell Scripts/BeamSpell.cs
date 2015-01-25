using UnityEngine;
using System.Collections;

public class BeamSpellRaycast : _BaseSpell {

	public GameObject collisionEffect;
	public GameObject castEffect;
	public float damagePerSecond;

	public override void Cast(float magnitude, Vector3 position, Vector3 offset, Quaternion rotation){

	} 

	void Start () {
		this.castType = Caster.BEAM;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
