using UnityEngine;
using System.Collections;

public class SimpleDestroy : MonoBehaviour, IDestroyable {


	public void Destroy(){
		Destroy (gameObject);
	}
}
