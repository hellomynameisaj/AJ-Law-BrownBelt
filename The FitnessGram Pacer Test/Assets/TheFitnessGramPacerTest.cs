using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheFitnessGramPacerTest : MonoBehaviour
{

    public float speed = 5;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
