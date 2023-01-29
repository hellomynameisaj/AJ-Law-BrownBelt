using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    public bool hit;

    int layerMask = 1 << 8;
    void Update()
    {
        hit = Physics.Raycast(transform.position, transform.forward, 2f, layerMask);
        Debug.DrawRay(transform.position, transform.forward * 2f, Color.red);

        if(hit == true)
        {
            Debug.Log("FU-");
        } 
        else
        {
            Debug.Log("go now");
        }
    }
}
