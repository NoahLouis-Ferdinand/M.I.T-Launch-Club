using UnityEngine;
using System.Collections;

public class MouseLookWithAnimation : MonoBehaviour {

	private Camera cam;
	private Animator anim;

	public float horizontalMouseSensitivity = 5;
	public float verticalMouseSensitivity = 7;
	public float verticalMouseAngleLimit = 80;
	public float horizontalRotateThreshold = 45;

	private float pitch = 0;
	private float yaw = 0;
	private float speed = 0;
	private Quaternion rotation;




	// Use this for initialization
	void Start () {
		cam = GetComponentInChildren<Camera> ();
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate () {
		//Get the pitch and yaw. 
		yaw += Input.GetAxis ("Mouse X")*horizontalMouseSensitivity;		 
		pitch -= Input.GetAxis ("Mouse Y")*verticalMouseSensitivity;

		//Make sure that pitch is within legal vertical angle
		pitch = Mathf.Clamp(pitch, -verticalMouseAngleLimit, verticalMouseAngleLimit);

		//Create a Quaternion from these values, and rotate the cam locally
		rotation = Quaternion.Euler(pitch,yaw,0);
		cam.transform.localRotation = rotation;

		//Calculate a point in the direction of the camera for the head to look at, and have it look that way
		//Ray ray = cam.ViewportPointToRay (new Vector3(0.5f, 0.5f, 0));
		//anim.SetLookAtPosition (Physics.RaycastAll(ray)[0].point); 
		//anim.SetLookAtWeight (1.0f);


		//Get the speed from the character's animator
		speed = anim.GetFloat ("Speed");

		float currentCamOffset = cam.transform.rotation.z - transform.rotation.z;
		Debug.Log (currentCamOffset);
		//we want the character to turn to face the direction of the camera if he looks to far to one side, or is moving.
		if (currentCamOffset !=0 &&(Mathf.Abs (currentCamOffset) >= horizontalRotateThreshold || speed != 0)) {
			//The character is moving, or is looking far enough to the side to mean its neccessary to turn
			Turn (cam.transform.rotation.z - transform.rotation.z);
		} else {
			anim.SetFloat ("Rotate",0);
		}

		//return rotate to 0, to prevent a loop. 
		//anim.SetFloat ("Rotate",0);
	}

	void Turn(float rotate){
		cam.transform.localRotation = Quaternion.Euler(pitch,yaw-rotate,0);
		anim.SetFloat ("Rotate", rotate);
	}
}
