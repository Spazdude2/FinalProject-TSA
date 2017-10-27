using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GobalGravity : MonoBehaviour 
{
	public GameObject Player;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) 
		{
			Physics.gravity = new Vector3 (0, -Physics.gravity.y, 0);
			Player.transform.Rotate (180, 0, 0);
		}
			
		if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			Physics.gravity = new Vector3 (0, Physics.gravity.y, 0);
			Player.transform.Rotate (-180, 0, 0);
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) 
		{
			Physics.gravity = new Vector3 (-Physics.gravity.x, 0, 0);
			Player.transform.Rotate (0, 0, -90);
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) 
		{
			Physics.gravity = new Vector3 (Physics.gravity.x, 0, 0);
			Player.transform.Rotate (0, 0, 90);
		}

	}
}
