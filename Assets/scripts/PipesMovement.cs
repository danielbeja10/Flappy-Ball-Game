using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PipesMovement : MonoBehaviour
{
    public addScore ADDSCORE;
    public float pipedeath = -50;
    public PipesSpawner spawn;
    private bool flag = true;

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        ADDSCORE = GameObject.FindGameObjectWithTag("scoretag").GetComponent<addScore>();
        spawn = GameObject.FindGameObjectWithTag("Respawn").GetComponent<PipesSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = transform.position + (Vector3.left * (ADDSCORE.movespeed)) * Time.deltaTime;
        if (transform.position.x < 25 && flag == true)
        {
            flag = false;
            spawn.spawnpipe();
        }
        if (transform.position.x < pipedeath)
        {
            Debug.Log("pipe deleted" + transform.position.x);
            Destroy(gameObject);
        }
    }
   
   

    
}
