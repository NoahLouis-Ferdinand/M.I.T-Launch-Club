using UnityEngine;
using System.Collections;

public class Caster : MonoBehaviour {

	// Use this for initialization
	private ICastable[] spells;
	public Vector3 offset;
	private Camera view;
	public int selection = 0;

	void Start () {
		spells = (ICastable[]) GetComponents(typeof(ICastable));
		view = (Camera) GetComponentInChildren<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			if(spells[selection]!=null){
				spells[selection].Cast(1, transform.position, offset, view.transform.rotation);
			}else{
				Debug.Log ("Failed attempting to cast spell at selection " + selection.ToString() + " because it was null!");
			}
		}
	}
}
