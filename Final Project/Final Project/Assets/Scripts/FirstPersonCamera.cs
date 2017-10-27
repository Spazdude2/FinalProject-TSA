using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour {
    
    public float sensitivity;
    public float maxLookAngle = 89;
   
    // Use this for initialization
    void Start () {

        Cursor.lockState = CursorLockMode.Locked;

    }
	
	// Update is called once per frame
	void Update () {

        Vector3 mouse = new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * sensitivity;
        Vector3 newRotation = transform.rotation.eulerAngles + mouse;
        
        if (!(newRotation.x < maxLookAngle || newRotation.x > 360 - maxLookAngle))
        {
            newRotation.x -= mouse.x;
        }

        transform.localRotation = Quaternion.Euler(newRotation);

    }
}
