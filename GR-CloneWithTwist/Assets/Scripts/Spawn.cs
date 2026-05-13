using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawn : MonoBehaviour
{

    public GameObject projectile;
    public GameObject targetPosition;

    [Range(0f,5f)]
    public float speed = 1f;

    public void SpawnSphere()
    {
        int spawnPointX = Random.Range(-10, 10);
        int spawnPointY = Random.Range(10, 20);
        int spawnPointZ = Random.Range(-10, 10);
        

        Instantiate(projectile, projectile.transform.position, Quaternion.identity);
      
    
    }
    




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        projectile.transform.position = Vector3.MoveTowards(projectile.transform.position, targetPosition.transform.position, speed*Time.deltaTime);
    }
      
}
