using UnityEngine;
using System.Collections;

public class InstantiateObjectAtCameraOnInput : MonoBehaviour {
	
	// Use this for initialization
	public GameObject objectToInstantiate;
	public Vector3 offset;
	public string inputName;
	private Camera camera;
	
	void Start () {
		camera = GetComponentInChildren<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown (inputName)){
			Vector3 rotatedOffset = transform.rotation*offset;
			Instantiate (objectToInstantiate,camera.transform.position+rotatedOffset, camera.transform.rotation);
		}
	}
}
