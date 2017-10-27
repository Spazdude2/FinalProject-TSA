using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeJump : MonoBehaviour
{
    public bool onGround;
    public float jumpPressure;//0
    public float minJump;//2
    public float maxJumpPressure;//10
    private Rigidbody rb;
    private Animator anim;

    public float speed;//10


    // Use this for initialization
    void Start()
    {
        onGround = true;
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onGround)
        {
            //hold jump button
            if (Input.GetButton("Jump"))
            {
                if (jumpPressure < maxJumpPressure)
                {
                    jumpPressure += Time.deltaTime * speed;
                }

                else
                {
                    jumpPressure = maxJumpPressure;
                }
				anim.SetFloat ("jumpPressure", jumpPressure + minJump);
            }

            else
            {
                if (jumpPressure > 0)
                {
                    jumpPressure = jumpPressure + minJump;
                    rb.velocity = new Vector3(0, jumpPressure, 0);
                    jumpPressure = 0;
                    onGround = false;
					anim.SetFloat ("jumpPressure", 0);
					anim.SetBool ("onGround", onGround);
                }
            }

        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Terrain"))
        {
            onGround = true;
			anim.SetBool ("onGround", onGround);
        }
    }
}
