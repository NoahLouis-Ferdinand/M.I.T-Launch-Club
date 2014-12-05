using UnityEngine;
using System.Collections;

public class InstantiateOnDestroy : MonoBehaviour, IDestroyable {

	public GameObject objectToInstantiate;

	public void Destroy(){
		if (objectToInstantiate != null) {
			Instantiate (objectToInstantiate,transform.position, transform.rotation);
		}
		Destroy (gameObject);
	}
}
