using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidFall : MonoBehaviour
{
    Vector3 spawnPoint;

    //Start is called before the first frame update
    void Start()
    {
        spawnPoint = gameObject.transform.position;
    }

    //Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -150f)
        {
            gameObject.transform.position = spawnPoint;
        }
    }
}