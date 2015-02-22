using UnityEngine;
using System.Collections;

public class NavigateToObject : MonoBehaviour {

	// Use this for initialization
	public string objectName;
	private Transform t;
	private NavMeshAgent nav;

	void Start () {
		t = GameObject.Find (objectName).transform;
		nav = GetComponent<NavMeshAgent> ();
		nav.SetDestination (t.position);
		Debug.Log (t.position);
	}
}
