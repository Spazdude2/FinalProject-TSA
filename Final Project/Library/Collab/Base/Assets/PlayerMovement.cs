using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{

    public float moveSpeed;

    private Vector3 moveDirection;

    public Transform FPS;
    
	void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}


    void Update()
    {
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;

		if (Input.GetKey (KeyCode.Escape)) 
		{
			Cursor.lockState = CursorLockMode.None;
		}
    }
    
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDirection));
    }	
}
