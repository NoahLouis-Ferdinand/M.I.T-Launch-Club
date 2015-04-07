using UnityEngine;
using System.Collections;

public class GravityManager : MonoBehaviour {

	public Texture2D gravityMap;
	//texture should be formatted as r = x, g = y, b = z, a = magnitude

	public float worldUnitsPerPixel = 1;
	public float baseGravityValue = 9.8f;
	public float zeroedColorValue = 100;

	public Vector3 GetGravityAtPoint(Vector3 position){
		Color col = gravityMap.GetPixel (Mathf.FloorToInt(position.x/worldUnitsPerPixel),Mathf.FloorToInt(position.y/worldUnitsPerPixel));
		float magnitude = (col.a / 255)*baseGravityValue;
		return new Vector3(((col.r-zeroedColorValue)/zeroedColorValue)*magnitude,((col.g-zeroedColorValue)/zeroedColorValue),((col.b-zeroedColorValue)/zeroedColorValue));
	}
}
