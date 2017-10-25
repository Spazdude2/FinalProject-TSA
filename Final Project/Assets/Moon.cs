using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public GameObject moon;

    public float OrbitalSpeed;
    public float scooch;
    public float Distance;

	// Use this for initialization
	void Start ()
    {
        moon = this.transform.gameObject;
	}
	
	// Update is called once per frame
	void Update ()
    {
        moon.transform.Translate(OrbitalSpeed, Distance, scooch);
	}
}
