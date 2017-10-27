using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour 
{
	public float PullRadius;
	public float GravitationalPull;
	public float MinRadius;
	public float DistanceMultiplier;

	public LayerMask LayerToPull;

	void FixedUpdate()
	{
		Collider[] colliders = Physics.OverlapSphere (transform.position, PullRadius, LayerToPull);

		foreach (var collider in colliders)
		{
			Rigidbody rb = collider.GetComponent<Rigidbody> ();

			if (rb == null) 
			{
				continue;
			}

			Vector3 Direction = transform.position - collider.transform.position;

			if (Direction.magnitude < MinRadius) 
			{
				continue;
			}

			float Distance = Direction.sqrMagnitude * DistanceMultiplier + 1;

			rb.AddForce (Direction.normalized * (GravitationalPull / Distance) * rb.mass * Time.fixedDeltaTime);


		}
	}
}
