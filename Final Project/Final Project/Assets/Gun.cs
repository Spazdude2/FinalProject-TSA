using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour 
{

	public GameObject shot;
	public Transform GunEnd;
	public float BulletSpeed;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown("Fire1"))
		{
			GameObject newShot = Instantiate(shot, GunEnd.transform.position + GunEnd.transform.forward * 0.5f, Quaternion.Euler(transform.rotation.eulerAngles));
			newShot.GetComponent<Rigidbody>().velocity = GunEnd.transform.forward * BulletSpeed;

		}
	}
}
