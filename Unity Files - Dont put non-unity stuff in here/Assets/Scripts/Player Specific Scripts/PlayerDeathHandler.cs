using UnityEngine;
using System.Collections;

public class PlayerDeathHandler : MonoBehaviour, IDestroyable {

	// Use this for initialization
	void Start () {
	
	}

	public void Destroy(){
		Destroy (gameObject);
	}
}
