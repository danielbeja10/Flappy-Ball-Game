using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudsGen : MonoBehaviour
{
    public GameObject[] clouds;
    public int index;
    
    
    void Start()
    {
       spawnCloud(transform.position.y);
        
    }
    
    public void spawnCloud(float z)
    {
        index = Random.Range(0,clouds.Length);
        Instantiate(clouds[index], new Vector3(transform.position.x ,z, 0), transform.rotation);
        
    }
    
}
