using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonProjectile : MonoBehaviour {

    public GameObject projectile;
    public GameObject projectileParent;
    
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            GameObject shot = Instantiate(projectile);
            shot.transform.position = transform.parent.position;
            shot.transform.position += Camera.main.transform.forward + Vector3.up * 0.5f;
            shot.GetComponent<Rigidbody>().velocity = Camera.main.transform.forward * 10;

            shot.transform.SetParent(projectileParent.transform);
        }
	}
}
