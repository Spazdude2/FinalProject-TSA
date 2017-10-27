using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour {
    
    public float sensitivity;
   
    // Use this for initialization
    void Start () {

        Cursor.lockState = CursorLockMode.Locked;

    }
	
	// Update is called once per frame
	void Update () {

        Vector3 mouse = new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * sensitivity;
        transform.localRotation = Quaternion.Euler(transform.rotation.eulerAngles + mouse);

    }
}
