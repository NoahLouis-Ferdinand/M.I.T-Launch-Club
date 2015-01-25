using UnityEngine;
using System.Collections;

public class GUI_Element_Bar_Horizontal : GUI_Element_RequiresFloatInput {
	
	public float maxValue;
	public Color color;
	public string label;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGui () {
		float value = this.Input.GetValue ();
		Vector2 drawPosition = this.GetLocation ();

	}


}
