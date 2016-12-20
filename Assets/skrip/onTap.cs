using UnityEngine;
using System.Collections;

public class onTap : MonoBehaviour {

	// Use this for initialization
	public void OnTapButton () 
	{
		gameObject.transform.localScale = new Vector3 (140,140,0);
	}
}
