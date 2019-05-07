using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBirdy : MonoBehaviour {
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print("There was a trigger");
        }
    }
}
