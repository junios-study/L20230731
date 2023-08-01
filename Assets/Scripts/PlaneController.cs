using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public float moveSpeed = 10.0f;
    public float rotateSpeed = 30.0f;

    public GameObject cubePlane;
    public GameObject f15c;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Time.deltaTime * moveSpeed *  Vector3.up);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Time.deltaTime * rotateSpeed * Vector3.forward);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Time.deltaTime * rotateSpeed * Vector3.back);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (cubePlane.active == false)
            {
                cubePlane.SetActive(true);
                f15c.SetActive(false);
            }
            else
            {
                cubePlane.SetActive(false);
                f15c.SetActive(true);
            }

        }
    }
}
