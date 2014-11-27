using UnityEngine;
using System.Collections;

public class FirstPersonController : MonoBehaviour {

	CharacterController controller;
	Camera camera;
	public float speedMultiplier = 5;
	public float terminalVelocity = 120;
	public float jumpImpulse = 3;
	public float standingHeight = 2;
	public float crouchedHeight = 1;
	private Vector3 velocity = Vector3.zero;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
		camera = GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
			
		// Movement
		velocity.y += Physics.gravity.y * Time.deltaTime;
		if( controller.isGrounded) {
			if(Input.GetButton("Jump")){velocity.y = jumpImpulse;}
			if(Input.GetButtonDown("Crouch")){
				Crouch(crouchedHeight);
			}
		}else{
			velocity.y = Mathf.Clamp(velocity.y, -terminalVelocity, terminalVelocity);
		}

		if(Input.GetButtonUp("Crouch")){
			controller.SimpleMove (new Vector3(0,20,0));
			Crouch(standingHeight);
		}

		velocity.x = Input.GetAxis("Horizontal")*speedMultiplier;
		velocity.z = Input.GetAxis("Vertical")*speedMultiplier;

		velocity = transform.rotation * velocity;
		controller.Move(velocity * Time.deltaTime);

	}

	private void Crouch(float height){
		controller.height = height;
		camera.transform.position.Set(0,height,0);

	}
}



