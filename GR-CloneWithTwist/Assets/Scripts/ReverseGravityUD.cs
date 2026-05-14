using UnityEngine;
using System.Collections;

public class ReverseGravityUD : MonoBehaviour
{
    
    private Rigidbody rb;
    public Vector3 customGravity = new Vector3(0,30f,0);
    private bool isInside = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.GetComponent<Rigidbody>())
        {
            rb = other.GetComponent<Rigidbody>();
            rb.useGravity = false;
            isInside = true;
        }

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isInside && rb != null)
        {
            rb.AddForce(customGravity, ForceMode.Acceleration);
             rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        }

    }
}
