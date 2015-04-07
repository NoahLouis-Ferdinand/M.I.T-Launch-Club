using UnityEngine;
using System.Collections;

public class Script_Player_Controller : MonoBehaviour {

	Animator anim;

	//Mouse Variables
	public float horizontalMouseSensitivity = 5;
	public float verticalMouseSensitivity = 7;
	public float mouseAngleLimit = 80;
	private float pitch = 0;
	Camera view;


	// Use this for initialization
	void Start () {
		anim = GetComponentInChildren<Animator> ();
		view = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {

		//Get Inputs
		float vertical = Input.GetAxis ("Vertical");
		float horizontal = Input.GetAxis ("Horizontal");
		bool jump = Input.GetButtonDown ("Jump");
		bool fire = Input.GetButtonDown ("Fire1");

		//Set animator stuffs
		anim.SetFloat ("Speed", vertical);
		anim.SetFloat ("Direction", horizontal);
		anim.SetBool ("Fire", fire);
		anim.SetBool ("Jump", jump);

		//MouseLook Stuff
		transform.Rotate(0,Input.GetAxis("Mouse X")*horizontalMouseSensitivity,0);
		pitch -= Input.GetAxis("Mouse Y") * verticalMouseSensitivity;
		pitch = Mathf.Clamp(pitch, -mouseAngleLimit, mouseAngleLimit);
		view.transform.Rotate (pitch,0,0);
		           
	}
}
