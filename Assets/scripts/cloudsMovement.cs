using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudsMovement : MonoBehaviour
{
    public addScore ADDSCORE;
    private bool flag = true;
    public cloudsGen generator;
    void Start()
    {
          ADDSCORE = GameObject.FindGameObjectWithTag("scoretag").GetComponent<addScore>();
          generator = GameObject.FindGameObjectWithTag("CG").GetComponent<cloudsGen>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + (Vector3.left*(ADDSCORE.movespeed/2)) * Time.deltaTime;
        if(transform.position.x <25 && transform.position.x >23 && flag == true)
        {
            flag = false;
            generator.spawnCloud(transform.position.y);
        }
        if(this.transform.position.x < -50)
        {
            Destroy(gameObject);
        }
    
   }     
}
