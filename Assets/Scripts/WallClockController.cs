using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallClockController : MonoBehaviour
{
    public GameObject HourLancet, MinuteLancet, SecondLancet;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rotateLancet(SecondLancet, (DateTime.Now.Second * 360 / 60));
        rotateLancet(MinuteLancet, (DateTime.Now.Minute * 360 / 60));
        rotateLancet(HourLancet, ((DateTime.Now.Hour % 12) * 360 / 12));
    }

    void rotateLancet(GameObject lancet, float angle)
    {
        lancet.transform.rotation = Quaternion.Euler(angle,0,0);
    }
}
