﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    public bool hit;
    void Update()
    {
        hit = Physics.Raycast(transform.position, Vector3.forward, .15f);
        Debug.DrawRay(transform.position, Vector3.forward * .15f, Color.red);
    }
}
