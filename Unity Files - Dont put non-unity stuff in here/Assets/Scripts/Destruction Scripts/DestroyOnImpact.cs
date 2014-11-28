using UnityEngine;
using System.Collections;

[RequireComponent(typeof(IDestroyable))]

public class DestroyOnImpact : MonoBehaviour {

	private IDestroyable destroy;

	void Start(){
		destroy = (IDestroyable) GetComponent(typeof(IDestroyable));
	}

	void OnCollisionEnter(Collision collison){
		destroy.Destroy ();
	}
}
