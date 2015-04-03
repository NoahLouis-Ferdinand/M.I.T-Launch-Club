using UnityEngine;
using System.Collections;

public interface IDestroyEvent{

	//Various classes that involve the handling of destroying objects will fire this method. Things that should happen when an object is destroyed should implement this to recieve events
	void OnDestroy();
}
