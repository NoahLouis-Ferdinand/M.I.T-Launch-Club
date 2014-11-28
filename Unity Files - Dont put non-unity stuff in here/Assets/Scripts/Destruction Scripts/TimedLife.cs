using UnityEngine;
using System.Collections;

[RequireComponent(typeof(IDestroyable))]

public class TimedLife : MonoBehaviour {

	// Use this for initialization
	public float lifeSpan;
	private IDestroyable destroy;

	void Start () {
		destroy = (IDestroyable) GetComponent (typeof(IDestroyable));
	}
	
	// Update is called once per frame
	void Update () {
		lifeSpan -= Time.deltaTime;
		if(lifeSpan<=0){
			destroy.Destroy();
		}
	}
}
