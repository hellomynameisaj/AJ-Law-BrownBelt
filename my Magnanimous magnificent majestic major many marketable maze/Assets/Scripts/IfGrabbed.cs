using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IfGrabbed : MonoBehaviour
{
    public Transform goal1;
    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("kermit is about to die");

        if (other.CompareTag("Player"))
        {
            Debug.Log("kermit dies");
            Destroy(gameObject);
            agent.destination = goal1.position;
        }
    }
}
