using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Control : MonoBehaviour
{
    
    private Jumpaction jumpaction;
    public nnnnnn ball;

    private void Awake()
    {
        ball = GameObject.FindGameObjectWithTag("Player").GetComponent<nnnnnn>();
    }



    public void restart()
    {
        ball.ballJump();
        PlayerPrefs.SetString("gamerestarted", "true");
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    
        
        
       
 
}
