using UnityEngine;

public class ColliderCamera : MonoBehaviour
{

    [SerializeField] private Transform targetCamera;
    [SerializeField] private CapsuleCollider capsuleCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (targetCamera == null || capsuleCollider == null) return;

        // Extract camera position
        Vector3 camPos = targetCamera.position;

        // Match X and Z, keep local Y offset or specific height
        Vector3 newCenter = transform.InverseTransformPoint(camPos);
        
        // Lock the collider center to the camera's X and Z
        capsuleCollider.center = new Vector3(newCenter.x, capsuleCollider.center.y, newCenter.z);
    }
}
