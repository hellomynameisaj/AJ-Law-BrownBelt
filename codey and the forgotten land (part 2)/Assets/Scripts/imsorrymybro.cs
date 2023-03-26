using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imsorrymybro : MonoBehaviour
{

    public GameObject CodeyVariant;

    public void OnTriggerEnter(Collider player)
    {
        Debug.Log("please god let this work");
         CodeyVariant.transform.Rotate(0, 0, 50 * Time.deltaTime); //rotates 50 degrees per second around z axis
    }
}
