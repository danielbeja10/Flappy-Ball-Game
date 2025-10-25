using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class nnnnnn : MonoBehaviour
{ 
    public Rigidbody2D myrigidody;
    public float flapstreagth;
    public addScore add;
    public bool ballisalive = true;// so the ball cant move after dying.
    public AudioSource jumpsound;
    public Jumpaction jumpaction;
    public GameObject pausescreen;
    

    private void Awake()
    {
        jumpaction = new Jumpaction();
        jumpaction.touch.Enable();
        jumpaction.touch.jump.started += jump;
        
    }

   

    // Update is called once per frame
    void Update()
    {
        if((transform.position.y < -30 || transform.position.y > 30 )&& ballisalive == true  )
        {
            jumpaction.touch.Disable();
            add.gameover();
            ballisalive= false;
        }
        
        

    }
    public void jump(InputAction.CallbackContext context)
    {
        if( ballisalive == true && context.started && pausescreen.activeInHierarchy == false)
        {
           
                jumpsound.Play();
                ballJump();
        }
        if(pausescreen.activeInHierarchy== true) 
        {
            jumpaction.touch.Disable();
        }

    }
   
    public void ballJump()
    {
        myrigidody.velocity = Vector2.up * flapstreagth;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(ballisalive==true)
        {
            jumpaction.touch.Disable();
            add.gameover();
            ballisalive = false;
            
        }
        
        
    }
}
