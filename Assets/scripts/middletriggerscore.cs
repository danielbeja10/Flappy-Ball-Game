using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class middletriggerscore : MonoBehaviour
{
    public nnnnnn checkIfAlive;
    public AudioSource coin;
    public addScore add;
    void Start()
    {
        add = GameObject.FindGameObjectWithTag("scoretag").GetComponent<addScore>();
        checkIfAlive = GameObject.FindGameObjectWithTag("Player").GetComponent<nnnnnn>();
        coin = GameObject.FindGameObjectWithTag("3").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            if(checkIfAlive.ballisalive == true)
            {
                coin.Play();
                add.addscore(1);
            }
            
          
        }
        
    }
}
