using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour {

    public GameObject broken;
    
    private void OnCollisionEnter(Collision collision)
    {
        GameObject a = Instantiate(broken, transform.parent);
        a.transform.position = transform.position;

        Destroy(collision.gameObject);
        Destroy(gameObject);
        
    }
}
