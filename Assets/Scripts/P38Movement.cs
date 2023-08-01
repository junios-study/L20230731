using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P38Movement : MonoBehaviour
{
    public float moveSpeed = 20.0f;

    // Update is called once per frame
    void Update()
    {
        float factor = Input.GetAxis("Fire1") * 5.0f;
        transform.Translate(Vector3.forward * moveSpeed * factor * Time.deltaTime);
        //if (Input.GetButton("Fire1"))
        //{
            
        //}
        //else
        //{
        //    //transform.Translate(transform.forward, Space.World);
        //    transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        //    //transform.Translate(-Vector3.right, Space.Self);
        //    //transform.Translate(-transform.right, Space.World);
        //}
    }
}
