using UnityEngine;
using System.Collections;

public class ReverseGravityUD : MonoBehaviour
{
    public Collider coll;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coll = GetComponent<Collider>();
        coll.isTrigger = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
            other.attachedRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
