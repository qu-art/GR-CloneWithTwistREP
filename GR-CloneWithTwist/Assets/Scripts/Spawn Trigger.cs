using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnTrigger : MonoBehaviour
{

    public GameObject otherGameObject;
    public Spawn spawn;


    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject spawn = GameObject.FindWithTag("Sphere");
        spawn.GetComponent<Spawn>().SpawnSphere();
        
    }

  


    // Update is called once per frame
    void Update()
    {
        
    }
}
