using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

	public float horizontalMouseSensitivity = 5;
	public float verticalMouseSensitivity = 7;
	public float mouseAngleLimit = 80;
	private float pitch = 0;
	Camera view;
	// Use this for initialization
	void Start () {
		view = GetComponentInChildren<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,Input.GetAxis("Mouse X")*horizontalMouseSensitivity,0);
		pitch -= Input.GetAxis("Mouse Y") * verticalMouseSensitivity;
		pitch = Mathf.Clamp(pitch, -mouseAngleLimit, mouseAngleLimit);
		view.transform.localRotation = Quaternion.Euler(pitch, 0, 0);
	}
}
