using UnityEngine;
using System.Collections;

public class _BaseSpell : MonoBehaviour, ICastable {
	
	private float m_baseManaCost;
	public float baseManaCost
	{	
		get{ return m_baseManaCost;}

		set
		{ 
			if(value>=0){
				m_baseManaCost = value;
			}
		}
	}


	private string m_castType;
	
	public string castType
	{
			get{return m_castType;}
			
			set{m_castType = value;	}
	}

	private string m_userFriendlyName;
	public string userFriendlyName
	{	
		get{ return m_userFriendlyName;}

		set{ m_userFriendlyName = value;}
	}

	public virtual void Cast(float magnitude, Vector3 position, Quaternion rotation){
		//Override this method!
	}
}
