using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurning : MonoBehaviour
{
    Vector2 Rotator;
    Vector2 Rotation;
    public float smoothing;
    public float sensitivity;

    public GameObject Player;

	// Use this for initialization
	void Start ()
    {
        Player = this.transform.gameObject;
	}
	
	// Update is called once per frame
	void Update ()
    {
        var md = new Vector2(Input.GetAxis("Mouse X"), 0);
        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        Rotation.x = Mathf.Lerp(Rotation.x, md.x, 1f / smoothing);
        Rotator += Rotation;

        Player.transform.localRotation = Quaternion.AngleAxis(Rotator.x, Player.transform.up);
    }
}
