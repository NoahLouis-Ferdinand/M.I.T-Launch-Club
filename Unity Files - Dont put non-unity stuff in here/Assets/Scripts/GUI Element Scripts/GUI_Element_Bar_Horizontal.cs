//using UnityEngine;
//using System.Collections;
//
//public class GUI_Element_Bar_Horizontal : GUI_Element_RequiresFloatInput {
//	
//	public float maxValue;
//	public Color color;
//	public Vector2 dimensions;
//	public string labelText = "";
//	public string labelTooltip = "";
//	public bool doLabel = true;
//	public bool dynamicLabel = true;
////	public float controlID;
////	GUIStyle style;
////	GUIContent content;
////	Rect drawBox;
////
////	// Use this for initialization
////	void Start () {
////		Vector2 drawPosition = this.GetLocation ();
////		drawBox = Rect.MinMaxRect(drawPosition.x, drawPosition.y,drawPosition.x+dimensions.x,drawposition.y+dimensions+x);
////		style = GUI.skin.GetStyle ("Label");
////		content = new GUIContent();
////		content.text = labelText;
////		content.tooltip = labelTooltip;
////	}
////
////	void OnGui () {
////		float value = this.Input.GetValue ();
////		if (doLabel) {
////			style.Draw (drawBox,content,controlID)
////		}
////	}
////
////
////}
