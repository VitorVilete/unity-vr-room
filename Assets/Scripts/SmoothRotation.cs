using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothRotation : MonoBehaviour
{
    //TODO: Fix Rotation and attach this script to the VR reticle
    private float angle = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        angle = DateTime.Now.Second * 360 / 60;
    }
    void FixedUpdate()
    {
        gameObject.transform.rotation = Quaternion.Euler(angle, 0, 0);
    }
}
