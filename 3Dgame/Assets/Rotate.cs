using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 editRotate;
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("s"))
        {
            transform.Rotate(-3, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            transform.Rotate(3, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(0, 0,-3);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 0, 3);
        }

        if (Input.GetKey("space"))
        {
            transform.Translate(0, 0.5f, 0);
        }
    }




}


