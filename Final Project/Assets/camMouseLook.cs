﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMouseLook : MonoBehaviour 
{
	Vector2 mouseLook;
	Vector2 smoothV;

	public float sensitivity;
	public float smoothing;

	GameObject character;

	// Use this for initialization
	void Start () 
	{
		character = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () 
	{
		var md = new Vector2 (Input.GetAxis ("Mouse X"), Input.GetAxis ("Mouse Y"));

		md = Vector2.Scale (md, new Vector2 (sensitivity * smoothing, sensitivity * smoothing));
		smoothV.x = Mathf.Lerp (smoothV.x, md.x, 1.0f / smoothing);
		smoothV.y = Mathf.Lerp (smoothV.y, md.y, 1.0f / smoothing);
		mouseLook += smoothV;
		mouseLook.y = Mathf.Clamp (mouseLook.y, -90.0f, 90.0f);

		transform.localRotation = Quaternion.AngleAxis (-mouseLook.y, Vector3.right);
		character.transform.localRotation = Quaternion.AngleAxis (mouseLook.x, character.transform.up);

	}
}