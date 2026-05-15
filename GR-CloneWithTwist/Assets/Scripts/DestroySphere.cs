using UnityEngine;

public class DestroySphere : MonoBehaviour
{

    void OnCollisionEnter (Collision collision)
    {
        if (collision.GameObject.CompareTag("Sword"))
        {
            Destroy(gameObject);
        }
    }





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
