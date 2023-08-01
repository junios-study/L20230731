using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleMovement : MonoBehaviour
{
    public float moveSpeed = 30.0f;
    GameObject player;
    private void Awake()
    {
        Destroy(gameObject, 3.0f);
        player = GameObject.FindGameObjectWithTag("Player");
    }

    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * moveSpeed * player.transform.up);
    }
}
