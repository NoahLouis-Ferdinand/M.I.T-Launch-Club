using UnityEngine;
using System.Collections;

public class Script_DestructionEvent_Instantiate : MonoBehaviour, IDestroyEvent {

	public GameObject prefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnDestroy(){
		Instantiate (prefab,transform.position,transform.rotation);
	}
}
