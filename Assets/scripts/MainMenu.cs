using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public GameObject ballawake;
    public GameObject pipeawake;
    public GameObject pauseawake;
    public GameObject mainmenusleep;
    public GameObject settingsawake;
    public nnnnnn ball;
    private bool ifStartedTheGame = false;
    public AudioManager am;
    

     void Start()
    {
        
    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space) == true && ifStartedTheGame == false || PlayerPrefs.GetString("gamerestarted") == "true" )
        {
            startgame();
        }
    }
    public void startgame()
    {
      
        ballawake.SetActive(true);
        pipeawake.SetActive(true);
        pauseawake.SetActive(true);
        mainmenusleep.SetActive(false);
        ball.ballJump();
        ifStartedTheGame = true;
        
    }

    public void settings()
    {
        mainmenusleep.SetActive(false);
        settingsawake.SetActive(true);

    }
    public void quitgame()
    {
        Application.Quit();
    }
    public void returnToMainMenu()
    {
        am.SaveStats();
        settingsawake.SetActive(false);
        mainmenusleep.SetActive(true);
    }
    
}
