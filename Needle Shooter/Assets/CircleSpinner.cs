using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CircleSpinner : MonoBehaviour
{
    public float turnSpeed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        turnSpeed = UnityEngine.Random.Range(1, 7);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, turnSpeed, Space.Self);
    }
}
