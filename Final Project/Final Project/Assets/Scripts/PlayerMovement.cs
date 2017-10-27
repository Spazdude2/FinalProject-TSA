using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    public float moveSpeed;
    private int jumps = 3;
    public int maxJumps = 3;

    void Start()
    {
    }

    void Update()
    {
        //Movement
        float derectionHorizontal = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        float derectionForward = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime ;

        Vector3 movement = Camera.main.transform.right * derectionHorizontal +
                            Camera.main.transform.forward * derectionForward;
        movement.y = 0;

        transform.position += movement;
        GetComponent<Rigidbody>().AddForce(movement * 100);
        
        //Jumps
        /*if (Input.GetKeyDown(KeyCode.Space) && jumps > 0)
        {
            jumps--;

            Vector3 vel = GetComponent<Rigidbody>().velocity;
            GetComponent<Rigidbody>().velocity = new Vector3(vel.x, 10, vel.z);
        }*/

    
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Terrain")
        {
            jumps = maxJumps;
        }

        if (other.tag == "Wall")
        {
            Camera.main.transform.parent.Rotate(Vector3.forward, 90);
        }
    }

}
