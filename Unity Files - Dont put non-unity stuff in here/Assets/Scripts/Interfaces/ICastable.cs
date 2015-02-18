using UnityEngine;
using System.Collections;

public interface ICastable {
	
	float baseManaCost{ get; set; }
	string userFriendlyName{ get; set; }
	string castType{ get; set; }


	void Cast(float magnitude, Vector3 position, Quaternion rotation);

}
