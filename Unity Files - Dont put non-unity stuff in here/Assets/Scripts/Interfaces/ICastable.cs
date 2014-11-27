using UnityEngine;
using System.Collections;

public interface ICastable {
	
	float GetBaseManaCost();

	void Cast(float magnitude, Vector3 position, Vector3 offset, Quaternion rotation);

}
