using UnityEngine;
using System.Collections;

public class Script_DestroyOnContact : MonoBehaviour {

	IDestroyEvent[] destructionClasses;

	// Use this for initialization
	void Start () {
		destructionClasses = GetComponents<IDestroyEvent> ();
	}

	void OnCollisionEnter(){
		if (destructionClasses.Length > 0) {
			foreach (IDestroyEvent item in destructionClasses) {
				item.OnDestroy ();
			}
		}
		Destroy (gameObject);
	}
}
