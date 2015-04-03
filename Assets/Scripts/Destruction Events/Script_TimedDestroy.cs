using UnityEngine;
using System.Collections;

public class Script_TimedDestroy : MonoBehaviour {

	IDestroyEvent[] destructionClasses;
	public float lifeTime = 5;
	
	// Use this for initialization
	void Start () {
		destructionClasses = GetComponents<IDestroyEvent> ();
	}
	
	void Update(){
		lifeTime -= Time.deltaTime;
		if(lifeTime <= 0){
			if (destructionClasses.Length > 0) {
				foreach (IDestroyEvent item in destructionClasses) {
					item.OnDestroy ();
				}
			}
			Destroy (gameObject);
		}
	}
}
