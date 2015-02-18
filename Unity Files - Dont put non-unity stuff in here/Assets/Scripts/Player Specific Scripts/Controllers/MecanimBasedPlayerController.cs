using UnityEngine;
using System.Collections;

[RequireComponent(typeof (Animator))]
[RequireComponent(typeof (CapsuleCollider))]
[RequireComponent(typeof (Rigidbody))]
public class MecanimBasedPlayerController : MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float direction = Input.GetAxis ("Horizontal");
		float speed = Input.GetAxis ("Vertical");
		animator.SetFloat ("Direction",direction);
		animator.SetFloat ("Speed",speed);
		animator.SetBool ("Jump",Input.GetButton("Jump"));
		animator.SetBool("Cast",Input.GetButton("Fire1"));
	}
}
