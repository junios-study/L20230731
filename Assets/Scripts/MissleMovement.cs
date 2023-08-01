using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MissleMovement : MonoBehaviour
{
    public float moveSpeed = 30.0f;
    //GameObject player;
    public Vector3 missleDirection;

    private void Awake()
    {
        Destroy(gameObject, 3.0f);
        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        //missleDirection = player.transform.up;
    }

    


    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Time.deltaTime * moveSpeed * transform.up, Space.World);
        //transform.position += Time.deltaTime * moveSpeed * transform.up;

        //transform.Translate(Time.deltaTime * moveSpeed * Vector3.up, Space.Self);
        transform.Translate(Time.deltaTime * moveSpeed * Vector3.up);

    }
}
