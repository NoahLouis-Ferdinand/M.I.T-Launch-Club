using UnityEngine;
using System.Collections;

public class Script_RGBNoiseScript : MonoBehaviour {

	public float loopduration;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
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
