using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotator : MonoBehaviour
{
    public float rotaionSpeed = 100.0f; //first
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotaionSpeed);
    }
}
