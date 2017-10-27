using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonProjectile : MonoBehaviour {

    public GameObject projectile;
    public GameObject transformParent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {

            GameObject shot = Instantiate(projectile, Camera.main.transform);
            shot.transform.position += Camera.main.transform.forward * 2 + Vector3.up * 2;
            shot.GetComponent<Rigidbody>().velocity = Camera.main.transform.forward * 10;

            shot.transform.SetParent(transformParent.transform);
        }
	}
}
