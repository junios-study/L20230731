using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject missle;

    public MissleSpawnPoint[] spawnPoints;

    void Awake()
    {
        spawnPoints = gameObject.GetComponentsInChildren<MissleSpawnPoint>();
        //GameObject.Find("")
        //GameObject.FindGameObjectsWithTag("Player")
        //gameObject.GetComponentInChildren<>
        //gameObject.GetComponentInParent<>
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var spawnPoint in spawnPoints)
            {
                GameObject newMissle = Instantiate(missle);
                newMissle.transform.position = spawnPoint.transform.position;
                newMissle.transform.rotation = spawnPoint.transform.rotation;
                //newMissle.GetComponent<MissleMovement>().missleDirection = spawnPoint.transform.up;
            }
        }
    }
}
