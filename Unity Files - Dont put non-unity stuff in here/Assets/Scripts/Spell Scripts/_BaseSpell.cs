using UnityEngine;
using System.Collections;

public class _BaseSpell : MonoBehaviour, ICastable {
	

	public float baseManaCost
	{	
		get{ return baseManaCost;}
		set{ baseManaCost = value;}
	}

	public string castType{	
		get{ return castType;}
		set{ castType = value;}
	}

	public string userFriendlyName
	{	
		get{ return userFriendlyName;}
		set{ userFriendlyName = value;}
	}

	public virtual void Cast(float magnitude, Vector3 position, Vector3 offset, Quaternion rotation){
		//Override this method!
	}
}
