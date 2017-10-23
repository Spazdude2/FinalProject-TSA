using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSong : MonoBehaviour
{
    [SerializeField]
    AudioSource One = null;

    [SerializeField]
    AudioSource Two = null;

    [SerializeField]
    AudioSource Three = null;

    [SerializeField]
    AudioSource Four = null;

    [SerializeField]
    AudioSource PKL = null;

	[SerializeField]
	AudioSource PKM = null;

	[SerializeField]
	AudioSource POL = null;

	[SerializeField]
	AudioSource Five = null;

    // Use this for initialization
    void Start ()
    {
        One.GetComponent<AudioSource>().enabled = false;
        Two.GetComponent<AudioSource>().enabled = false;
        Three.GetComponent<AudioSource>().enabled = false;
        Four.GetComponent<AudioSource>().enabled = false;
        PKL.GetComponent<AudioSource>().enabled = false;
		PKM.GetComponent<AudioSource>().enabled = false;
		POL.GetComponent<AudioSource>().enabled = false;
		Five.GetComponent<AudioSource>().enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown("1"))
        {
            One.GetComponent<AudioSource>().enabled = true;
            Two.GetComponent<AudioSource>().enabled = false;
            Three.GetComponent<AudioSource>().enabled = false;
            Four.GetComponent<AudioSource>().enabled = false;
            PKL.GetComponent<AudioSource>().enabled = false;
			PKM.GetComponent<AudioSource>().enabled = false;
			POL.GetComponent<AudioSource>().enabled = false;
			Five.GetComponent<AudioSource>().enabled = false;
        }

        if (Input.GetKeyDown("2"))
        {
            One.GetComponent<AudioSource>().enabled = false;
            Two.GetComponent<AudioSource>().enabled = true;
            Three.GetComponent<AudioSource>().enabled = false;
            Four.GetComponent<AudioSource>().enabled = false;
            PKL.GetComponent<AudioSource>().enabled = false;
			PKM.GetComponent<AudioSource>().enabled = false;
			POL.GetComponent<AudioSource>().enabled = false;
			Five.GetComponent<AudioSource>().enabled = false;
        }

        if (Input.GetKeyDown("3"))
        {
            One.GetComponent<AudioSource>().enabled = false;
            Two.GetComponent<AudioSource>().enabled = false;
            Three.GetComponent<AudioSource>().enabled = true;
            Four.GetComponent<AudioSource>().enabled = false;
            PKL.GetComponent<AudioSource>().enabled = false;
			PKM.GetComponent<AudioSource>().enabled = false;
			POL.GetComponent<AudioSource>().enabled = false;
			Five.GetComponent<AudioSource>().enabled = false;
        }

        if (Input.GetKeyDown("4"))
        {
            One.GetComponent<AudioSource>().enabled = false;
            Two.GetComponent<AudioSource>().enabled = false;
            Three.GetComponent<AudioSource>().enabled = false;
            Four.GetComponent<AudioSource>().enabled = true;
            PKL.GetComponent<AudioSource>().enabled = false;
			PKM.GetComponent<AudioSource>().enabled = false;
			POL.GetComponent<AudioSource>().enabled = false;
			Five.GetComponent<AudioSource>().enabled = false;
        }

		if (Input.GetKeyDown("5"))
		{
			One.GetComponent<AudioSource>().enabled = false;
			Two.GetComponent<AudioSource>().enabled = false;
			Three.GetComponent<AudioSource>().enabled = false;
			Four.GetComponent<AudioSource>().enabled = false;
			PKL.GetComponent<AudioSource>().enabled = false;
			PKM.GetComponent<AudioSource>().enabled = false;
			POL.GetComponent<AudioSource>().enabled = false;
			Five.GetComponent<AudioSource>().enabled = true;
		}

		if (Input.GetKey("p") && Input.GetKey("k") && Input.GetKey("l"))
        {
            One.GetComponent<AudioSource>().enabled = false;
            Two.GetComponent<AudioSource>().enabled = false;
            Three.GetComponent<AudioSource>().enabled = false;
            Four.GetComponent<AudioSource>().enabled = false;
            PKL.GetComponent<AudioSource>().enabled = true;
			PKM.GetComponent<AudioSource>().enabled = false;
			POL.GetComponent<AudioSource>().enabled = false;
			Five.GetComponent<AudioSource>().enabled = false;
        }

		if (Input.GetKey("p") && Input.GetKey("k") && Input.GetKey("m"))
		{
			One.GetComponent<AudioSource>().enabled = false;
			Two.GetComponent<AudioSource>().enabled = false;
			Three.GetComponent<AudioSource>().enabled = false;
			Four.GetComponent<AudioSource>().enabled = false;
			PKL.GetComponent<AudioSource>().enabled = false;
			PKM.GetComponent<AudioSource>().enabled = true;
			POL.GetComponent<AudioSource>().enabled = false;
			Five.GetComponent<AudioSource>().enabled = false;
		}

		if (Input.GetKey("m") && Input.GetKey("v") && Input.GetKey("l"))
		{
			One.GetComponent<AudioSource>().enabled = false;
			Two.GetComponent<AudioSource>().enabled = false;
			Three.GetComponent<AudioSource>().enabled = false;
			Four.GetComponent<AudioSource>().enabled = false;
			PKL.GetComponent<AudioSource>().enabled = false;
			PKM.GetComponent<AudioSource>().enabled = false;
			POL.GetComponent<AudioSource>().enabled = true;
			Five.GetComponent<AudioSource>().enabled = false;
		}

        if (Input.GetKeyDown("u"))
        {
            One.GetComponent<AudioSource>().enabled = false;
            Two.GetComponent<AudioSource>().enabled = false;
            Three.GetComponent<AudioSource>().enabled = false;
            Four.GetComponent<AudioSource>().enabled = false;
            PKL.GetComponent<AudioSource>().enabled = false;
			PKM.GetComponent<AudioSource>().enabled = false;
			POL.GetComponent<AudioSource>().enabled = false;
			Five.GetComponent<AudioSource>().enabled = false;
        }
    }
}
