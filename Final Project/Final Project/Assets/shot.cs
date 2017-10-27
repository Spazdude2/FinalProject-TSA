using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour 
{
	public float waitTime;
	public float radius;
	public float explosionForce;
	// Use this for initialization
	void Start () 
	{
		StartCoroutine (Blast ());
    }
	
	IEnumerator Blast()
	{
		yield return new WaitForSeconds (waitTime);
		Collider[] objects = Physics.OverlapSphere (this.transform.position, radius);
		foreach (Collider gameobj in objects) 
		{
			if (gameobj.gameObject.GetComponent<Rigidbody>() != null && this.transform.GetComponent<SphereCollider>()) 
			{
				gameobj.gameObject.GetComponent<Rigidbody> ().AddExplosionForce (explosionForce, this.transform.position, radius);
			}	
		}
		Destroy (this.gameObject);
	}
}
