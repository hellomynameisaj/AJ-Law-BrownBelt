using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject coin;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("hi");
            Destroy(gameObject);
            Destroy(door);
        }
    }
}