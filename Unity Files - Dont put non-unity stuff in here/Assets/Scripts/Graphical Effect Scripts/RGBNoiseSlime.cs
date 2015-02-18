using UnityEngine;
using System.Collections;

public class RGBNoiseSlime : MonoBehaviour {

	float loopduration;
	public float loopdurationDefault = 2;
	public float loopdurationMin = 0.2f;
	public float loopdurationMax = 10;
	public float velocityWobbleMultiplier = 1;
	float velocityWobble = 0;
	Rigidbody body;

	// Use this for initialization
	void Start () {
		body = GetComponentInParent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		velocityWobble = body.velocity.magnitude;
		loopduration = Mathf.Clamp (((loopdurationDefault)/(velocityWobble*velocityWobbleMultiplier)),loopdurationMin,loopdurationMax);
		Debug.Log (loopduration);

		float r = Mathf.Sin (((Time.time) / loopduration)*2*Mathf.PI)+0.75f;
		float g = Mathf.Sin(((Time.time) / loopduration + 0.33333f)*2*Mathf.PI)+0.75f;
		float b = Mathf.Sin(((Time.time) / loopduration + 0.66666f)*2*Mathf.PI)+0.75f;
		float correction = 1 / (r + g + b);
		r *= correction;
		g *= correction;
		b *= correction;
		renderer.material.SetVector ("_ChannelFactor", new Vector4 (r,g,b,0));
	}
}
