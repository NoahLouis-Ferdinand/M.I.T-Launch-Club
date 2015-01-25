using UnityEngine;
using System.Collections;

public class GUI_Element : MonoBehaviour {

	public bool display = true;
	public Vector2 drawLocation;
	public GUI_Element parent;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetLocation(Vector2 loc){
		drawLocation = loc;
	}

	public Vector2 GetLocation(){
		return drawLocation;
	}

	Vector2 GetDrawLocation(){
		return this.drawLocation + parent.drawLocation;
	}
	


}
