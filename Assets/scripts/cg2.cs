using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cg2 : MonoBehaviour
{
    public GameObject[] clouds;
    public int index;
    
    
    void Start()
    {
        spawnCloud();
    }
    void update()
    {

        
    }
    public void spawnCloud()
    {
        index = Random.Range(0,clouds.Length);
        Instantiate(clouds[index], new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
    
}
