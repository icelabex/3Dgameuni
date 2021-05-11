using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 force;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

        private void OnCollisionEnter(Collision collision)
        {

        if (collision.gameObject.tag == "Floor")
        {

        }
        print("hit");
            rb.AddForce(force);
        }
   
}
