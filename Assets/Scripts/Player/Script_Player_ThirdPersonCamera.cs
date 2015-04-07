using UnityEngine;
using System.Collections;

public class Script_Player_ThirdPersonCamera : MonoBehaviour {
	
	Transform camPosR;
	Transform camPosL;
	Transform camPosCenter;
	Vector3 camPosition;
	public string camPosRName = "CamPosR";
	public string camPosLName = "CamPosL";
	public string camPosCenterName = "CamZoomCenter";
	public bool isOnRight = true;
	public float smooth = 0.0f;

	Vector3 target;
	Quaternion targetRotation;

	// Use this for initialization
	void Start () {

		camPosR = GameObject.Find (camPosRName).transform;
		camPosL = GameObject.Find (camPosLName).transform;
		camPosCenter = GameObject.Find (camPosCenterName).transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftAlt)){
			isOnRight = !isOnRight;
		}
		if(isOnRight){
			target = Vector3.Lerp(transform.position,camPosR.position,smooth);
			targetRotation = camPosR.rotation;
		}else{
			target = Vector3.Lerp (transform.position,camPosL.position,smooth);
			targetRotation = camPosL.rotation;
		}
		RaycastHit hitInfo;
		if(Physics.Linecast(camPosCenter.position,target,out hitInfo)){
			target = hitInfo.point;
		}
		if(Input.GetKey (KeyCode.LeftControl)){
			target = Vector3.Lerp (target,camPosCenter.position,0.3f);
		}
		transform.position = target;
		transform.rotation = targetRotation;
	}
}
