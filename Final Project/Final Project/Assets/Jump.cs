using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour 
{
	public float JumpPower;
	public int jumps;
	int SetJumps;

	Rigidbody rb;

	// Use this for initialization
	void Start () 
	{
		rb = this.GetComponent<Rigidbody> ();
		SetJumps = jumps;
	}

	// Update is called once per frame
	void Update ()
	{
		if (jumps > 0) 
		{
			if (Input.GetButtonDown ("Jump")) 
			{
				jumps--;
				this.rb.GetComponent<Rigidbody> ().AddForce (0, JumpPower, 0);
			}
		}
	}

	void OnCollisionEnter (Collision collision)
	{
		jumps = SetJumps;
	}
}