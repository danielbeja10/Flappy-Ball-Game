using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseScript : MonoBehaviour
{
    public GameObject pausescreen;
    public GameObject gameoverscreen;
    public nnnnnn ball;
   
    public void pausemethod()
   {
    if (gameoverscreen.activeSelf == false)
        { 
            
            pausescreen.SetActive(true);
            Time.timeScale = 0f;
        }
    else
        {
            pausescreen.SetActive(false);
        }
    
   }
   public void resumeMethod()
    { 
       
        pausescreen.SetActive(false);
        Time.timeScale = 1f;
    }
   public void returntomenu()
   {
        
        PlayerPrefs.SetString("gamerestarted", "false");
        Time.timeScale = 1f;
        SceneManager.LoadScene("START");
       
    }
}
