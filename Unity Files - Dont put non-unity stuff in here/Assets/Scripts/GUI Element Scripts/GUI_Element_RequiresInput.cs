using UnityEngine;
using System.Collections;

public class GUI_Element_RequiresFloatInput : GUI_Element{

	public IFloatQuantifiable Input;

	public void SetInputClass(IFloatQuantifiable input){
		this.Input = input;
	}


}
