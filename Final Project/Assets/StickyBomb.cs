using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyBomb : MonoBehaviour 
{
	public GameObject explosion;

	void OnCollisionEnter(Collision collision)
	{
		this.GetComponent<Rigidbody>().isKinematic = true;
	}
}
