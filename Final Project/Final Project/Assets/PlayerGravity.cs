using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour
{
    public PlanetGravity attractorPlanet;
    private Transform playerTransform;

	// Use this for initialization
	void Start ()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        playerTransform = transform;

    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
		if (attractorPlanet)
        {
            attractorPlanet.Attract(playerTransform);
        }
	}
}
