using UnityEngine;
using System.Collections;

public class nextScene : MonoBehaviour {

	public int level;

	void Update()
	{
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	public void Play()
	{
		Application.LoadLevel(level);
	}

	public void Quit()
	{
		Application.Quit ();
	}
}
