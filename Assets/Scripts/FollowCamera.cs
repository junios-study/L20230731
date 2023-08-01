using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject player;
    public float smoothTime = 0.05f;
    Vector3 velocity;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        velocity = player.transform.forward * player.GetComponent<P38Movement>().moveSpeed;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //transform.position = Vector3.Lerp(transform.position, player.transform.position, Time.deltaTime * 2.0f);
        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position, ref velocity, smoothTime);
        transform.rotation = Quaternion.Slerp(transform.rotation,  player.transform.rotation, 
            Time.deltaTime * 2.0f);
    }
}
